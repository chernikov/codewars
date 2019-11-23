export function findUniq(arr: number[]): number {

   let slice = arr.slice(0, 3);
   console.log(slice);
   if (slice[0] === slice[1] && slice[1] === slice[2]) {
      return arr.filter(p => p != slice[0])[0];
   }
   if (slice[0] === slice[1]) {
     return slice[2];
   }
   if (slice[0] === slice[2]) {
     return slice[1];
   }
   return slice[0];
}
