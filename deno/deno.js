const food = Deno.args[0]
const parent = Deno.args[1]

if(food === 'love' && parent === 'ryan') {
  console.log('🤮... Deno is born');
} else {
  console.log('🤨... This deno needs some love');
}

setTimeout(() => {
  console.log('check')
},1000)
console.log(window)
