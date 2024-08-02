package Leetcode

import "sort"

func successfulPairs(spells []int, potions []int, success int64) []int {
	sort.Ints(potions)
	result := make([]int, len(spells))

	for i, spell := range spells {
		left, right := 0, len(potions)-1
		for left <= right {
			mid := left + (right-left)/2
			if int64(potions[mid])*int64(spell) >= success {
				right = mid - 1
			} else {
				left = mid + 1
			}
		}
		result[i] = len(potions) - left
	}
	return result
}
