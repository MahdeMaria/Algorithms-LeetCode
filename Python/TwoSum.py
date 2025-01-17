target = 9
nums = [2,7,11,15]

def twoSum(nums, target):
    a = {}
    i = 0  
    for i in range(len(nums)):
        dif = target - nums[i] 
        if dif in a:
            return [a[dif], i];
        
        a[nums[i]] = i
    

print(twoSum(nums, target));