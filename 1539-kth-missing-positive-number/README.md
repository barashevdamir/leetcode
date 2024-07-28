<h2><a href="https://leetcode.com/problems/kth-missing-positive-number/description/">1539. Kth Missing Positive Number</a>
</h2><h3>Easy</h3><hr><div><p>Given an array <code>arr</code> of positive integers sorted in a <strong>strictly increasing order</strong>, and an integer <code>k</code>.</p>
<p>Return the <code>k<sup>th</sup></code> <strong>positive</strong> integer that is <strong>missing</strong> from this array.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre><strong>Input:</strong> arr = [2,3,4,7,11], k = 5
<strong>Output:</strong> 9
<strong>Explanation:</strong> The missing positive integers are [1,5,6,8,9,10,12,13,...]. The 5th missing positive integer is 9.
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre><strong>Input:</strong> arr = [1,2,3,4], k = 2
<strong>Output:</strong> 6
<strong>Explanation:</strong> The missing positive integers are [5,6,7,...]. The 2nd missing positive integer is 6.
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 <= arr.length <= 1000</code></li>
    <li><code>1 <= arr[i] <= 1000</code></li>
    <li><code>1 <= k <= 1000</code></li>
    <li><code>arr[i] < arr[j]</code> for <code>1 <= i < j <= arr.length</code></li>
</ul>

<p><strong>Follow up:</strong></p>
<p>Could you solve this problem in less than O(n) complexity?</p>