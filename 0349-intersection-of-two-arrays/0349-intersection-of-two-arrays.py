class Solution:
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        se = set(nums1)
        
        res = []
        
        for n in nums2:
            if n in se:
                res.append(n)
                se.remove(n)
        return res