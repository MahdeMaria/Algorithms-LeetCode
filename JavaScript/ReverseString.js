s = ["h","e","l","l","o"]

var reverseString = function(s) {
    for(s1 = 0, s2 = s.length -1; s1 < s2; s1++, s2--){
           var temp = s[s1] 
           s[s1] = s[s2] 
           s[s2] = temp 
       }
        console.log(s) 
};

reverseString(s)