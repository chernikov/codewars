function isSame(a : string, b : string) : number {
    var astr = a.toLowerCase().split('').sort()
    .filter((value, index, self) => self.indexOf(value) === index).join('');
  var bstr = b.toLowerCase().split('').sort()
    .filter((value, index, self) => self.indexOf(value) === index).join('');
  if (astr > bstr) {
  return -1;
  }
  if (bstr > astr) {
    return 1;
  }
  return 0;
  }

export function findUniq(arr: string[]): string {
  arr = arr.sort(isSame);
  return isSame(arr[0], arr[1]) == 0 ? arr[arr.length - 1] : arr[0];
}
