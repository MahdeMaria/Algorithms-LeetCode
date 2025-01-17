
target = 9
nums = [2,7,11,15]

var twoSum = function(nums, target) {
    var a = {} 
    for(var i = 0; i < nums.length; i++){
        var dif = target - nums[i] 
        if(a[dif] !== undefined){
            return [a[dif], i];
        }
        a[nums[i]] = i
    } 
};

console.log(twoSum(nums, target));