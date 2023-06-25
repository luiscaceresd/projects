// try{
//   console.log(a+b);
// } catch(err){
//   console.log(err)
//   console.log('there was an error');
// }
// console.log('not reached');

try{
  throw new ReferenceError()
} catch(err){
  console.log('there was an error');
}
console.log('not reached');