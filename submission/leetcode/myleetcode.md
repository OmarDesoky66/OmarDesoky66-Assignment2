# Reverse a String Problem

time complexity: O(n)
auxiliary space complexity: O(1)
space complexity: O(n)

[LeetCode Submission link](https://leetcode.com/problems/reverse-string/submissions/2144078786/)

I Used the two-pointer technique to reverse the string in place.
The left pointer starts at the beginning of the string, and the right pointer starts at the end.
We swap the characters at these pointers and move them towards each other until they meet in the middle.