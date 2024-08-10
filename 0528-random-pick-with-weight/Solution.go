package Leetcode

import "math/rand"

type Solution struct {
	_weights []int
}

func Constructor(w []int) Solution {
	_weights := make([]int, len(w))
	_weights[0] = w[0]
	for i := 1; i < len(w); i++ {
		_weights[i] = _weights[i-1] + w[i]
	}
	return Solution{_weights}
}

func (this *Solution) PickIndex() int {
	randNum := rand.Intn(this._weights[len(this._weights)-1])
	left, right := 0, len(this._weights)-1
	for left < right {
		mid := left + (right-left)/2
		if randNum < this._weights[mid] {
			right = mid
		} else {
			left = mid + 1
		}
	}
	return left
}

/**
 * Your Solution object will be instantiated and called as such:
 * obj := Constructor(w);
 * param_1 := obj.PickIndex();
 */
