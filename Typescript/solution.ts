export const findOdd = (xs: number[]): number => {
  return xs.reduce((a,b)=> {
    return a^b; //XOR 
  } );
  // let dict = Array<{ x: number; count: number }>();
  // xs.forEach(num => {
  //   let item = dict.filter(p => p.x == num)[0];
  //   if (item) {
  //     item.count++;
  //   } else {
  //     dict.push({ x: num, count: 1 });
  //   }
  // });
  // let number = dict.filter(p => p.count % 2 == 1)[0];
  // return number.x;
};
