// removeDuplicates does all the work of removing duplicates from the array, testTenTimes runs ten random number arrays through the removeDuplicates function and logs the results

const removeDuplicates = (initialArray) => Array.from(new Set(initialArray));

const testTenTimes = () => {
  for (let i = 0; i < 10; i++) {
    const testArray = Array.from({ length: 10 }, () =>
      Math.floor(Math.random() * 10)
    );
    console.log(
      `Initial Array: ${testArray}\nNo Duplicates: ${removeDuplicates(
        testArray
      )}\n`
    );
  }
};

testTenTimes();
