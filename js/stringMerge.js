function stringMerge(arr1, arr2) {
    merged = []

    while (arr1.length || arr2.length > 0) {
        if (arr1.length > 0) {
            merged.push(arr1.shift())
        }
        if (arr2.length > 0) {
            merged.push(arr2.shift())
        }
    }
    return merged.join('')
}
l1 = ["a", "b", "c"]
l2 = ["f", "d", "s"]
console.log(stringMerge(l1, l2))