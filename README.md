# C#

Create lib

`dotnet new classlib -f netcoreapp3.0 -n CodeWars`

Create NUnit Tests

`dotnet new nunit -f netcoreapp3.0 -n CodeWars.Tests`

Add reference 
```
cd ./CodeWars.Tests
dotnet add reference ../CodeWars/CodeWars.csproj
```

Run Test 

```
dotnet test
```


# Typescript

Create project 

`npm init`

Install packages
```
npm i --save-dev typescript
npm i --save-dev ts-node
npm i --save-dev mocha 
npm i --save-dev chai
```
create solution.ts
```
export const somefunction = (xs: number[]): number => {
    return 0;
}  
```

create tests/solution.test.ts
```
import { somefunction} from '../solution';
import { assert } from 'chai';


describe('Example tests', function() {
 somefunction(....);
  doTest([10], 10);
});


function doTest(a: number[], n: number) {
  it(`xs = ${JSON.stringify(a)} ; n = ${n}`, () => {
    assert.strictEqual(somefunction(a), n);
  });
}
```
in package.json 
```
"scripts": {
    "test": "mocha -r ts-node/register tests/**/*.test.ts",
    "build": "tsc"
  },
```

run test 

`npm run test`
