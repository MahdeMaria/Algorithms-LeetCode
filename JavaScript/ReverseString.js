s = ["h","e","l","l","o"]

var reverseString = function(s) {
    for(start = 0, end = s.length -1; start < end; start++, end--){
           var temp = s[start] 
           s[start] = s[end] 
           s[end] = temp 
       }
        console.log(s) 
};

reverseString(s)