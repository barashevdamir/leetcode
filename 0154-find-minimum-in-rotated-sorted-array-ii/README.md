<h2><a href="https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/description/">154. Find Minimum in Rotated Sorted Array II</a>
</h2><h3>Hard</h3><hr><div><p>Suppose an array of length <code>n</code> sorted in ascending order is <strong>rotated</strong> between <code>1</code> and <code>n</code> times. For example, the array <code>nums = [0,1,4,4,5,6,7]</code> might become:</p>
<ul>
<li><code>[4,5,6,7,0,1,4]</code> if it was rotated <code>4</code> times.</li>
<li><code>[0,1,4,4,5,6,7]</code> if it was rotated <code>7</code> times.</li>
</ul>
<p>Notice that <strong>rotating</strong> an array <code>[a[0], a[1], a[2], ..., a[n-1]]</code> 1 time results in the array <code>[a[n-1], a[0], a[1], a[2], ..., a[n-2]]</code>.</p>
<p>Given the sorted rotated array <code>nums</code> that may contain <strong>duplicates</strong>, return the minimum element of this array.</p>
<p>You must decrease the overall operation steps as much as possible.</p>
<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre><strong>Input:</strong> nums = [1,3,5]
<strong>Output:</strong> 1
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre><strong>Input:</strong> nums = [2,2,2,0,1]
<strong>Output:</strong> 0
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>n == nums.length</code></li>
    <li><code>1 <= n <= 5000</code></li>
    <li><code>-5000 <= nums[i] <= 5000</code></li>
	<li>All the integers of <code>nums</code> are <strong>unique</strong>.</li>
	<li><code>nums</code> is sorted and rotated between <code>1</code> and <code>n</code> times.</li>
</ul>
