package Leetcode

func nextGreatestLetter(letters []byte, target byte) byte {
	leftIndex := 0
	rightIndex := len(letters) - 1
	for leftIndex <= rightIndex {
		midIndex := leftIndex + (rightIndex-leftIndex)/2
		if letters[midIndex] <= target {
			leftIndex = midIndex + 1
		} else {
			rightIndex = midIndex - 1
		}
	}
	return letters[leftIndex%len(letters)]
}
