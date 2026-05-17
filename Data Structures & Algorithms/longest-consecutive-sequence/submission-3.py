class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if not nums:
            return 0
        set_arr = set(nums)
        max_length = 0
        cur_length = 1
        val = nums[0]
        i = 0
        for num in nums:
            cur_length, cur_num = 0, num
            while cur_num in set_arr:
                cur_length += 1
                cur_num += 1
            max_length = max(max_length, cur_length)

        
        return max_length
                


        