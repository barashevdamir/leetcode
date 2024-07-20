<h2><a href="https://leetcode.com/problems/time-based-key-value-store/description/">981. Time Based Key-Value Store</a>
</h2><h3>Medium</h3><hr><div><p>Design a time-based key-value data structure that can store multiple values for the same key at different time stamps and retrieve the key's value at a certain timestamp.</p>
<p>Implement the <code>TimeMap</code> class:</p>
<ul>
    <li><code>TimeMap()</code> Initializes the object of the data structure.</li>
    <li><code>void set(String key, String value, int timestamp)</code> Stores the key <code>key</code> with the value <code>value</code> at the given time <code>timestamp</code>.</li>
    <li><code>String get(String key, int timestamp)</code> Returns a value such that <code>set</code> was called previously, with <code>timestamp_prev <= timestamp</code>. If there are multiple such values, it returns the value associated with the largest <code>timestamp_prev</code>. If there are no values, it returns <code>""</code>.</li>
</ul>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre><strong>Input:</strong> intervals = [[1,2]]
<strong>Output:</strong> [-1]
<strong>Explanation:</strong> There is only one interval in the collection, so it outputs -1.
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre><strong>Input:</strong>
["TimeMap", "set", "get", "get", "set", "get", "get"]
[[], ["foo", "bar", 1], ["foo", 1], ["foo", 3], ["foo", "bar2", 4], ["foo", 4], ["foo", 5]]
<strong>Output:</strong>
[null, null, "bar", "bar", null, "bar2", "bar2"]
<strong>Explanation:</strong>
TimeMap timeMap = new TimeMap();
timeMap.set("foo", "bar", 1);  // store the key "foo" and value "bar" along with timestamp = 1.
timeMap.get("foo", 1);         // return "bar"
timeMap.get("foo", 3);         // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
timeMap.set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
timeMap.get("foo", 4);         // return "bar2"
timeMap.get("foo", 5);         // return "bar2"
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 <= key.length, value.length <= 100</code></li>
    <li><code>key</code> and <code>value</code> consist of lowercase English letters and digits.</li>
	<li><code>1 <= timestamp <= 10<sup>7</sup></code></li>
	<li>All the timestamps <code>timestamp</code> of <code>set</code> are strictly increasing.</li>
	<li>At most <code>2 * 10<sup>5</sup></code> calls will be made to <code>set</code> and <code>get</code>.</li>
</ul>
