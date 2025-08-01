"use strict";
// 1 ЗАДАНИЕ
{
    console.log('1 ЗАДАНИЕ');
    function createPhoneNumber(numbers) {
        return `(${numbers[0]}${numbers[1]}${numbers[2]}) ${numbers[3]}${numbers[4]}${numbers[5]}-${numbers[6]}${numbers[7]}${numbers[8]}${numbers[9]}`;
    }
    let numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
    console.log(createPhoneNumber(numbers));
}
// 2 ЗАДАНИЕ
{
    console.log('2 ЗАДАНИЕ');
    class Challenge {
        static solution(number) {
            let result = 0;
            if (number < 1)
                return 0;
            for (let element = 0; element < number; element++) {
                if (element % 3 == 0 || element % 5 == 0)
                    result += element;
            }
            return result;
        }
    }
    console.log(Challenge.solution(16));
}
// 3 ЗАДАНИЕ
{
    console.log('3 ЗАДАНИЕ');
    let nums = [1, 2, 3, 4, 5, 6, 7];
    function rotateArrayToRight(nums, k) {
        if (k < 0 || nums.length == 0)
            return 0;
        for (let element = 0; element < k; element++) {
            let buf = nums[nums.length - 1];
            nums.pop();
            nums.unshift(buf);
        }
        return nums;
    }
    console.log(rotateArrayToRight(nums, 95));
}
// 4 ЗАДАНИЕ 
{
    console.log('4 ЗАДАНИЕ');
    let nums1 = [1, 3, 5];
    let nums2 = [2, 4, 6];
    function findMediane(nums1, nums2) {
        let resultArr = formattingArrays(nums1, nums2);
        let mediane = 0;
        if (resultArr.length % 2 == 0) {
            mediane = (resultArr[resultArr.length / 2] + resultArr[(resultArr.length / 2) - 1]) / 2;
        }
        else {
            mediane = resultArr[Math.floor(resultArr.length / 2)];
        }
        return mediane;
    }
    function formattingArrays(nums1, nums2) {
        let resultArr = unionArray(nums1, nums2);
        resultArr.sort(compare);
        return resultArr;
    }
    function unionArray(nums1, nums2) {
        return [...nums1, ...nums2];
    }
    function compare(num1, num2) {
        if (num1 > num2)
            return 1;
        if (num1 < num2)
            return -1;
        return 0;
    }
    console.log(findMediane(nums1, nums2));
}
