import {assert} from "chai";
import {findUniq} from '../solution';

describe('findUniq', () => {
  it('should handle sample cases', () => {
    assert.strictEqual(findUniq([ 1, 1, 1, 2, 1, 1 ]), 2);
    assert.strictEqual(findUniq([ 4, 4, 'foo', 4 ]), 'foo');
    // assert.strictEqual(findUniq(['abc', 'acb', 'bac', 'foo', 'bca', 'cab', 'cba']), 'foo');
    // assert.strictEqual(findUniq(['silvia', 'vasili', 'victor']), 'victor');
    // assert.strictEqual(findUniq(['Tom Marvolo Riddle', 'I am Lord Voldemort', 'Harry Potter']), 'Harry Potter');
    // assert.strictEqual(findUniq(['    ', 'a', ' ']), 'a');

    // assert.strictEqual(findUniq([ '', '', '', 'a', '', '' ]), 'a');
    // assert.strictEqual(findUniq([ '    ', '  ', ' ', 'a', ' ', '' ]), 'a');
    // assert.strictEqual(findUniq([ 'foobar', 'barfo', 'fobara', '   ', 'fobra', 'oooofrab' ]), '   ');
  });
});