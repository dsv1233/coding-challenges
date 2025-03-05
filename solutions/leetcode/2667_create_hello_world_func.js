var createHelloWorld = function(){
    return function(...args){
        return "Hello World"
    }
};

const f = createHelloWorld();
console.log(f()); 
console.log(f(1)); 
console.log(f('a', 'b')); 
console.log(f(1, 'a')); 
console.log(f('a', 1));