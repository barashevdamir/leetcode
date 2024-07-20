package Leetcode

type TimeValue struct {
	timestamp int
	value     string
}

type TimeMap struct {
	store map[string][]TimeValue
}

func Constructor() TimeMap {

	return TimeMap{
		store: make(map[string][]TimeValue),
	}
}

func (this *TimeMap) Set(key string, value string, timestamp int) {

	if _, ok := this.store[key]; !ok {
		this.store[key] = []TimeValue{{timestamp, value}}
	}
	this.store[key] = append(this.store[key], TimeValue{timestamp, value})
}

func (this *TimeMap) Get(key string, timestamp int) string {

	if _, ok := this.store[key]; !ok {
		return ""
	}
	var list = this.store[key]
	var left = 0
	var right = len(list) - 1
	for left <= right {
		var mid = left + (right-left)/2
		if list[mid].timestamp == timestamp {
			return list[mid].value
		}
		if list[mid].timestamp < timestamp {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}
	if right < 0 {
		return ""
	}
	return list[right].value
}
