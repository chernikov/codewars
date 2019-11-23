function isSame(a : any, b : any) : number 
{   
    let astr = a.toString();
    let bstr = b.toString();
    if (astr > bstr) {
      return -1;
    }
    if (bstr > astr) {
      return 1;
    }
    return 0;
}

export function findUniq(arr) {
  arr = arr.sort(isSame);
  return isSame(arr[0], arr[1]) == 0 ? arr[arr.length - 1] : arr[0];
}


/*
function findUniq(arr) { 
return arr.find(i => i === i && arr.indexOf(i) == arr.lastIndexOf(i));
}
*/