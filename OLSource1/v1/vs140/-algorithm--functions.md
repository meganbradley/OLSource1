---
title: "&lt;algorithm&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c10b0c65-410c-4c83-abf8-8b7f61bba8d0
caps.latest.revision: 14
---
# &lt;algorithm&gt; functions
||||  
|-|-|-|  
|[&lt;alg&gt; move](#alg_move)|[adjacent_find](#adjacent_find)|[all_of](#all_of)|  
|[any_of](#any_of)|[binary_search](#binary_search)|[copy](#copy)|  
|[copy_backward](#copy_backward)|[copy_if](#copy_if)|[copy_n](#copy_n)|  
|[count](#count)|[count_if](#count_if)|[equal](#equal)|  
|[equal_range](#equal_range)|[fill](#fill)|[fill_n](#fill_n)|  
|[find](#find)|[find_end](#find_end)|[find_first_of](#find_first_of)|  
|[find_if](#find_if)|[find_if_not](#find_if_not)|[for_each](#for_each)|  
|[generate](#generate)|[generate_n](#generate_n)|[includes](#includes)|  
|[inplace_merge](#inplace_merge)|[is_heap](#is_heap)|[is_heap_until](#is_heap_until)|  
|[is_partitioned](#is_partitioned)|[is_permutation](#is_permutation)|[is_sorted](#is_sorted)|  
|[is_sorted_until](#is_sorted_until)|[iter_swap](#iter_swap)|[lexicographical_compare](#lexicographical_compare)|  
|[lower_bound](#lower_bound)|[make_heap](#make_heap)|[max](#max)|  
|[max_element](#max_element)|[merge](#merge)|[min](#min)|  
|[min_element](#min_element)|[minmax](#minmax)|[minmax_element](#minmax_element)|  
|[mismatch](#mismatch)|[move_backward](#move_backward)|[next_permutation](#next_permutation)|  
|[none_of](#none_of)|[nth_element](#nth_element)|[partial_sort](#partial_sort)|  
|[partial_sort_copy](#partial_sort_copy)|[partition](#partition)|[partition_copy](#partition_copy)|  
|[partition_point](#partition_point)|[pop_heap](#pop_heap)|[prev_permutation](#prev_permutation)|  
|[push_heap](#push_heap)|[random_shuffle](#random_shuffle)|[remove](#remove)|  
|[remove_copy](#remove_copy)|[remove_copy_if](#remove_copy_if)|[remove_if](#remove_if)|  
|[replace](#replace)|[replace_copy](#replace_copy)|[replace_copy_if](#replace_copy_if)|  
|[replace_if](#replace_if)|[reverse](#reverse)|[reverse_copy](#reverse_copy)|  
|[rotate](#rotate)|[rotate_copy](#rotate_copy)|[search](#search)|  
|[search_n](#search_n)|[set_difference](#set_difference)|[set_intersection](#set_intersection)|  
|[set_symmetric_difference](#set_symmetric_difference)|[set_union](#set_union)|[sort](#sort)|  
|[sort_heap](#sort_heap)|[stable_partition](#stable_partition)|[stable_sort](#stable_sort)|  
|[std::shuffle](#std__shuffle)|[swap](#swap)|[swap_ranges](#swap_ranges)|  
|[transform](#transform)|[unique](#unique)|[unique_copy](#unique_copy)|  
|[upper_bound](#upper_bound)|  
  
##  \<a name="adjacent_find">\</a>  adjacent_find  
 Searches for two adjacent elements that are either equal or satisfy a specified condition.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The binary predicate giving the condition to be satisfied by the values of the adjacent elements in the range being searched.  
  
### Return Value  
 A forward iterator to the first element of the adjacent pair that are either equal to each other (in the first version) or that satisfy the condition given by the binary predicate (in the second version), provided that such a pair of elements is found. Otherwise, an iterator pointing to <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> is returned.  
  
### Remarks  
 The <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> algorithm is a nonmutating sequence algorithm. The range to be searched must be valid; all pointers must be dereferenceable and the last position is reachable from the first by incrementation. The time complexity of the algorithm is linear in the number of elements contained in the range.  
  
 The <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> used to determine the match between elements must impose an equivalence relation between its operands.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **L = ( 50 40 10 20 20 )**  
**There are two adjacent elements that are equal.**  
 **They have a value of 20.**  
**There are two adjacent elements where the second is twice the first.**  
 **They have values of 10 & 20.**    
##  \<a name="all_of">\</a>  all_of  
 Returns <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> when a condition is present at each element in the given range.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start to check for a condition. The iterator marks where a range of elements starts.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range of elements to check for a condition.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A condition to test for. This is a user-defined predicate function object that defines the condition to be satisfied by an element being checked. A predicate takes a single argument and returns <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the condition is detected at each element in the indicated range, and <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> if the condition is not detected at least one time.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> only if, for each <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
##  \<a name="any_of">\</a>  any_of  
 Returns <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> when a condition is present at least once in the specified range of elements.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start checking a range of elements for a condition.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range of elements to check for a condition.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A condition to test for. This is provided by a user-defined predicate function object. The predicate defines the condition to be satisfied by the element being tested. A predicate takes a single argument and returns <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> if the condition is detected at least once in the indicated range, <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> if the condition is never detected.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> only if, for some <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> in the range  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> is true.  
  
##  \<a name="binary_search">\</a>  binary_search  
 Tests whether there is an element in a sorted range that is equal to a specified value or that is equivalent to it in a sense specified by a binary predicate.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The value required to be matched by the value of the element or that must satisfy the condition with the element value specified by the binary predicate.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>when satisfied and <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> when not satisfied.  
  
### Return Value  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> if an element is found in the range that is equal or equivalent to the specified value; otherwise, <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>.  
  
### Remarks  
 The sorted source range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted range must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
 The value types of the forward iterators need to be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to ( <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="copy">\</a>  copy  
 Assigns the values of elements from a source range to a destination range, iterating through the source sequence of elements and assigning them new positions in a forward direction.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 An input iterator addressing the position that is one past the final element in the source range.  
  
 *_DestBeg*  
 An output iterator addressing the position of the first element in the destination range.  
  
### Return Value  
 An output iterator addressing the position that is one past the final element in the destination range, that is, the iterator addresses <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> + ( <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> ).  
  
### Remarks  
 The source range must be valid and there must be sufficient space at the destination to hold all the elements being copied.  
  
 Because the algorithm copies the source elements in order beginning with the first element, the destination range can overlap with the source range provided the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> position of the source range is not contained in the destination range. **copy** can be used to shift elements to the left but not the right, unless there is no overlap between the source and destination ranges. To shift to the right any number of positions, use the [copy_backward](../vs140/-algorithm--functions.md#copy_backward) algorithm.  
  
 The **copy** algorithm only modifies values pointed to by the iterators, assigning new values to elements in the destination range. It cannot be used to create new elements and cannot insert elements into an empty container directly.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  For another sample showing how to use copy, see [accumulate, copy, and vector::push_back Sample](../vs140/accumulate--copy--and-vector--push_back.md).  
  
 **v1 = ( 0 10 20 30 40 50 )**  
**v2 = ( 0 3 6 9 12 15 18 21 24 27 30 )**  
**v2 with v1 insert = ( 0 3 6 9 0 10 20 21 24 27 30 )**  
**v2 with shifted insert = ( 0 3 0 10 20 10 20 21 24 27 30 )**    
##  \<a name="copy_backward">\</a>  copy_backward  
 Assigns the values of elements from a source range to a destination range, iterating through the source sequence of elements and assigning them new positions in a backward direction.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position that is one past the final element in the source range.  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
### Return Value  
 An output iterator addressing the position that is one past the final element in the destination range, that is, the iterator addresses <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> – ( <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> ).  
  
### Remarks  
 The source range must be valid and there must be sufficient space at the destination to hold all the elements being copied.  
  
 The <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> algorithm imposes more stringent requirements than that the copy algorithm. Both its input and output iterators must be bidirectional.  
  
 The <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> and [move_backward](../vs140/-algorithm--functions.md#move_backward) algorithms are the only Standard Template Library algorithms designating the output range with an iterator pointing to the end of the destination range.  
  
 Because the algorithm copies the source elements in order beginning with the last element, the destination range can overlap with the source range provided the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> position of the source range is not contained in the destination range. <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> can be used to shift elements to the right but not the left, unless there is no overlap between the source and destination ranges. To shift to the left any number of positions, use the [copy](../vs140/-algorithm--functions.md#copy) algorithm.  
  
 The <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> algorithm only modifies values pointed to by the iterators, assigning new values to elements in the destination range. It cannot be used to create new elements and cannot insert elements into an empty container directly.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="copy_if">\</a>  copy_if  
 In a range of elements, copies the elements that are <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> for the specified condition.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 An input iterator that indicates the start of a range to check for the condition.  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range.  
  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 The output iterator that indicates the destination for the copied elements.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 The condition against which every element in the range is tested. This condition is provided by a user-defined predicate function object. A predicate takes one argument and returns <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
### Return Value  
 An output iterator that equals <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> incremented once for each element that fulfills the condition. In other words, the return value minus <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> equals the number of copied elements.  
  
### Remarks  
 The template function evaluates  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
  
 once for each <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> starting with the lowest value. If <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
##  \<a name="copy_n">\</a>  copy_n  
 Copies a specified number of elements.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 An input iterator that indicates where to copy elements from.  
  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of elements to copy.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 An output iterator that indicates where to copy elements to.  
  
### Return Value  
 Returns an output iterator where elements have been copied to. It is the same as the returned value of the third parameter, <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function evaluates <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>.  
  
##  \<a name="count">\</a>  count  
 Returns the number of elements in a range whose values match a specified value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be traversed.  
  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be traversed.  
  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 The value of the elements to be counted.  
  
### Return Value  
 The difference type of the **InputIterator** that counts the number of elements in the range [ <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> ) that have value <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 This algorithm is generalized to count elements that satisfy any predicate with the template function [count_if](../vs140/-algorithm--functions.md#count_if).  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **v1 = ( 10 20 10 40 10 )**  
**The number of 10s in v2 is: 3.**    
##  \<a name="count_if">\</a>  count_if  
 Returns the number of elements in a range whose values satisfy a specified condition.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be counted. A predicate takes single argument and returns **true** or **false**.  
  
### Return Value  
 The number of elements that satisfy the condition specified by the predicate.  
  
### Remarks  
 This template function is a generalization of the algorithm [count](../vs140/-algorithm--functions.md#count), replacing the predicate "equals a specific value" with any predicate.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **v1 = ( 10 20 10 40 10 )**  
**The number of elements in v1 greater than 10 is: 2.**    
##  \<a name="equal">\</a>  equal  
 Compares two ranges element by element for equality or equivalence in a sense specified by a binary predicate.  
  
 Use std::equal when comparing elements in different container types (for example vector and list) or when comparing different element types, or when you need to compare sub-ranges of containers. Otherwise, when comparing elements of the same type in the same container type, use the non-member operator== that is provided for each container.  
  
 Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be tested.  
  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first range to be tested.  
  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be tested.  
  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 An input iterator addressing the position of one past the last element in the second range to be tested.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 **true** if and only if the ranges are identical or equivalent under the binary predicate when compared element by element; otherwise, **false**.  
  
### Remarks  
 The range to be searched must be valid; all iterators must be dereferenceable and the last position is reachable from the first by incrementation.  
  
 If the two ranges are equal length, then the time complexity of the algorithm is linear in the number of elements contained in the range. Otherwise the function immediately returns <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
 Neither the <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> nor the user-defined predicate is required to impose an equivalence relation that symmetric, reflexive and transitive between its operands.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="equal_range">\</a>  equal_range  
 Given an ordered range, finds the subrange in which all elements are equivalent to a given value.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 The value being searched for in the ordered range.  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is less than another.  
  
### Return Value  
 A pair of forward iterators that specify a subrange, contained within the range searched, in which all of the elements are equivalent to <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> in the sense defined by the binary predicate used (either <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> or the default, less-than).  
  
 If no elements in the range are equivalent to <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>, the returned pair of forward iterators are equal and specify the point where <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> could be inserted without disturbing the order of the range.  
  
### Remarks  
 The first iterator of the pair returned by the algorithm is [lower_bound](../vs140/-algorithm--functions.md#lower_bound), and the second iterator is [upper_bound](../vs140/-algorithm--functions.md#upper_bound).  
  
 The range must be sorted according to the predicate provided to <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>. For example, if you are going to use the greater-than predicate, the range must be sorted in descending order.  
  
 Elements in the possibly empty subrange defined by the pair of iterators returned by <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> will be equivalent to <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> in the sense defined by the predicate used.  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to ( <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="fill">\</a>  fill  
 Assigns the same new value to every element in a specified range.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be traversed.  
  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be traversed.  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 The value to be assigned to elements in the range [ <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>).  
  
### Remarks  
 The destination range must be valid; all pointers must be dereferenceable, and the last position is reachable from the first by incrementation. The complexity is linear with the size of the range.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 30 35 40 45 )**  
**Modified v1 = ( 0 5 10 15 20 2 2 2 2 2 )**    
##  \<a name="fill_n">\</a>  fill_n  
 Assigns a new value to a specified number of elements in a range beginning with a particular element.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the range to be assigned the value <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of elements to be assigned the value.  
  
 <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 The value to be assigned to elements in the range [ <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>,                                 *First + Count*).  
  
### Return Value  
 An iterator to the element that follows the last element filled if <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> > zero, otherwise the first element.  
  
### Remarks  
 The destination range must be valid; all pointers must be dereferenceable, and the last position is reachable from the first by incrementation. The complexity is linear with the size of the range.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="find">\</a>  find  
 Locates the position of the first occurrence of an element in a range that has a specified value.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched for the specified value.  
  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched for the specified value.  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 The value to be searched for.  
  
### Return Value  
 An input iterator addressing the first occurrence of the specified value in the range being searched. If no element is found with an equivalent value, returns <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 For a code example using <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>, see [find_if()](../vs140/-algorithm--functions.md#find_if).  
  
##  \<a name="find_end">\</a>  find_end  
 Looks in a range for the last subsequence that is identical to a specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the last element in the range to be searched.  
  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to search for.  
  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the last element in the range to search for.  
  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator addressing the position of the first element of the last subsequence within [First1, Last1) that matches the specified sequence [First2, Last2).  
  
### Remarks  
 The <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position is reachable from the first by incrementation.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 5 10 15 20 )**  
**Vector v2 = ( 20 30 40 )**  
**There is a match of L1 in v1 that begins at position 7.**  
**There is a sequence of elements in v1 that are equivalent to those**  
 **in v2 under the binary predicate twice and that begins at position 8.**    
##  \<a name="find_first_of">\</a>  find_first_of  
 Searches for the first occurrence of any of several values within a target range or for the first occurrence of any of several elements that are equivalent in a sense specified by a binary predicate to a specified set of the elements.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be matched.  
  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be matched.  
  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
### Remarks  
 The <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position is reachable from the first by incrementation.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 15 20 )**  
**Vector v2 = ( 20 30 40 )**  
**There is at least one match of L1 in v1**  
 **and the first one begins at position 3.**  
**There is a sequence of elements in v1 that are equivalent**  
 **to those in v2 under the binary predicate twice**  
 **and the first one begins at position 2.**    
##  \<a name="find_if">\</a>  find_if  
 Locates the position of the first occurrence of an element in a range that satisfies a specified condition.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be satisfied by the element being searched for. A predicate takes single argument and returns <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> (satisfied) or <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> (not satisfied). The signature of <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> must effectively be <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> is a type to which <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> can be implicitly converted when dereferenced. The <CodeContentPlaceHolder>328\</CodeContentPlaceHolder> keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
### Return Value  
 An input iterator that refers to the first element in the range that satisfies the condition specified by the predicate (the predicate results in <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>). If no element is found to satisfy the predicate, returns <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>.  
  
### Remarks  
 This template function is a generalization of the algorithm [find](../vs140/-algorithm--functions.md#find), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does not satisfy the predicate), see [find_if_not](../vs140/-algorithm--functions.md#find_if_not).  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
##  \<a name="find_if_not">\</a>  find_if_not  
 Returns the first element in the indicated range that does not satisfy a condition.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be not satisfied by the element being searched for. A predicate takes single argument and returns <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> (satisfied) or <CodeContentPlaceHolder>335\</CodeContentPlaceHolder> (not satisfied). The signature of <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> must effectively be <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> is a type to which <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> can be implicitly converted when dereferenced. The <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
### Return Value  
 An input iterator that refers to the first element in the range that does not satisfy the condition specified by the predicate (the predicate results in <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>). If all elements satisfy the predicate (the predicate results in <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> for every element), returns <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>.  
  
### Remarks  
 This template function is a generalization of the algorithm [find](../vs140/-algorithm--functions.md#find), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does satisfy the predicate), see [find_if](../vs140/-algorithm--functions.md#find_if).  
  
 For a code example readily adaptable to <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>, see [find_if()](../vs140/-algorithm--functions.md#find_if).  
  
##  \<a name="for_each">\</a>  for_each  
 Applies a specified function object to each element in a forward order within a range and returns the function object.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be operated on.  
  
 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range operated on.  
  
 <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
 User-defined function object that is applied to each element in the range.  
  
### Return Value  
 A copy of the function object after it has been applied to all of the elements in the range.  
  
### Remarks  
 The algorithm <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> is very flexible, allowing the modification of each element within a range in different, user-specified ways. Templatized functions may be reused in a modified form by passing different parameters. User-defined functions may accumulate information within an internal state that the algorithm may return after processing all of the elements in the range.  
  
 The range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The complexity is linear with at most ( <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**Multiplying the elements of the vector v1**  
 **by the factor -2 gives:**  
 **v1mod1 = ( 8 6 4 2 0 -2 -4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 gives:**  
 **v1mod2 = ( 40 30 20 10 0 -10 -20 ).**  
**The average of the elements of v1 is:**  
 **Average ( v1mod2 ) = 10.**    
##  \<a name="generate">\</a>  generate  
 Assigns the values generated by a function object to each element in a range.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to which values are to be assigned.  
  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to which values are to be assigned.  
  
 <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>  
 A function object that is called with no arguments that is used to generate the values to be assigned to each of the elements in the range.  
  
### Remarks  
 The function object is invoked for each element in the range and does not need to return the same value each time it is called. It may, for example, read from a file or refer to and modify a local state. The generator's result type must be convertible to the value type of the forward iterators for the range.  
  
 The range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The complexity is linear, with exactly ( <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>) calls to the generator being required.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **Vector v1 is ( 41 18467 6334 26500 19169 ).**  
**Deque deq1 is ( 15724 11478 29358 26962 24464 ).**    
##  \<a name="generate_n">\</a>  generate_n  
 Assigns the values generated by a function object to a specified number of elements in a range and returns to the position one past the last assigned value.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>  
 An output iterator addressing the position of first element in the range to which values are to be assigned.  
  
 <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of elements to be assigned a value by the generator function.  
  
 <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>  
 A function object that is called with no arguments that is used to generate the values to be assigned to each of the elements in the range.  
  
### Remarks  
 The function object is invoked for each element in the range and does not need to return the same value each time it is called. It may, for example, read from a file or refer to and modify a local state. The generator's result type must be convertible to the value type of the forward iterators for the range.  
  
 The range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The complexity is linear, with exactly <CodeContentPlaceHolder>359\</CodeContentPlaceHolder> calls to the generator being required.  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="includes">\</a>  includes  
 Tests whether one sorted range contains all the elements contained in a second sorted range, where the ordering or equivalence criterion between elements may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 **true** if the first sorted range contains all the elements in the second sorted range; otherwise, **false**.  
  
### Remarks  
 Another way to think of this test is that it determined whether the second source range is a subset of the first source range.  
  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the algorithm includes in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. More precisely, the algorithm tests whether all the elements in the first sorted range under a specified binary predicate have equivalent ordering to those in the second sorted range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (                        *_Last1 – _First1*) – (                        *_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  **Original vector v1a with range sorted by the**  
 **binary predicate less than is v1a = ( -2 -1 0 1 2 3 4 ).**  
**Original vector v1b with range sorted by the**  
 **binary predicate less than is v1b = ( -2 -1 0 1 2 3 ).**  
**Original vector v2a with range sorted by the**  
 **binary predicate greater is v2a = ( 4 3 2 1 0 -1 ).**  
**Original vector v2b with range sorted by the**  
 **binary predicate greater is v2b = ( 3 2 1 0 -1 -2 ).**  
**Original vector v3a with range sorted by the**  
 **binary predicate mod_lesser is v3a = ( 0 1 2 3 4 ).**  
**Original vector v3b with range sorted by the**  
 **binary predicate mod_lesser is v3b = ( 0 -1 1 -2 2 3 ).**  
**All the elements in vector v1b are contained in vector v1a.**  
**At least one of the elements in vector v2b is not contained in vector v2a.**  
**At least one of the elements in vector v3b is  not contained under mod_lesser in vector v3a.**    
##  \<a name="inplace_merge">\</a>  inplace_merge  
 Combines the elements from two consecutive sorted ranges into a single sorted range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the first of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the last element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Remarks  
 The sorted consecutive ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted consecutive ranges must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>369\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges. The operation is stable as the relative order of elements within each range is preserved. When there are equivalent elements in both source ranges, the element is the first range precedes the element from the second in the combined range.  
  
 The complexity depends on the available memory as the algorithm allocates memory to a temporary buffer. If sufficient memory is available, the best case is linear with (                        *_Last – _First*) – 1 comparisons; if no auxiliary memory is available, the worst case is                         *N* log *(N)*, where                         *N* = (                        *_Last – _First*).  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  **Original vector v1 with subranges sorted by the**  
 **binary predicate less than is  v1 = ( 0 1 2 3 4 5 -5 -4 -3 -2 -1 0 )**  
**Original vector v2 with subranges sorted by the**  
 **binary predicate greater is v2 = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Original vector v3 with subranges sorted by the**  
 **binary predicate mod_lesser is v3 = ( 0 1 2 3 4 5 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with default order,**  
 **vector v1mod = ( -5 -4 -3 -2 -1 0 0 1 2 3 4 5 )**  
**Merged inplace with binary predicate greater specified,**  
 **vector v2mod = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with binary predicate mod_lesser specified,**  
 **vector v3mod = ( 0 0 1 -1 2 -2 3 -3 4 -4 5 -5 )**    
##  \<a name="is_heap">\</a>  is_heap  
 Returns <CodeContentPlaceHolder>370\</CodeContentPlaceHolder> if the elements in the specified range form a heap.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 A random access iterator that indicates the start of a range to check for a heap.  
  
 <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
 A random access iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
 A condition to test to order elements. A binary predicate takes a single argument and returns <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>376\</CodeContentPlaceHolder> if the elements in the specified range form a heap, <CodeContentPlaceHolder>377\</CodeContentPlaceHolder> if they do not.  
  
### Remarks  
 The first template function returns [is_heap_until](../vs140/-algorithm--functions.md#is_heap_until)<CodeContentPlaceHolder>378\</CodeContentPlaceHolder> <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>.  
  
 The second template function returns  
  
 <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>387\</CodeContentPlaceHolder> <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>.  
  
##  \<a name="is_heap_until">\</a>  is_heap_until  
 Returns an iterator positioned at the first element in the range [ <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>) that does not satisfy the heap ordering condition, or <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> if the range forms a heap.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>  
 A random access iterator that specifies the first element of a range to check for a heap.  
  
 <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>  
 A random access iterator that specifies the end of the range to check for a heap.  
  
 <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>  
 A binary predicate that specifies the strict weak ordering condition that defines a heap. The default predicate when <CodeContentPlaceHolder>396\</CodeContentPlaceHolder> is not specified is <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>398\</CodeContentPlaceHolder> if the specified range forms a heap or contains one or fewer elements. Otherwise, returns an iterator for the first element found that does not satisfy the heap condition.  
  
### Remarks  
 The first template function returns the last iterator <CodeContentPlaceHolder>399\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>400\</CodeContentPlaceHolder> <CodeContentPlaceHolder>401\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>402\</CodeContentPlaceHolder> is a heap ordered by the function object <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>. If the distance <CodeContentPlaceHolder>404\</CodeContentPlaceHolder> <CodeContentPlaceHolder>405\</CodeContentPlaceHolder> <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>, the function returns <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same as the first, except that it uses the predicate <CodeContentPlaceHolder>409\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>410\</CodeContentPlaceHolder> as the heap ordering condition.  
  
##  \<a name="is_partitioned">\</a>  is_partitioned  
 Returns <CodeContentPlaceHolder>411\</CodeContentPlaceHolder> if all the elements in the given range that test <CodeContentPlaceHolder>412\</CodeContentPlaceHolder> for a condition come before any elements that test <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 An input iterator that indicates where a range starts to check for a condition.  
  
 <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns true when all of the elements in the given range that test <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> for a condition come before any elements that test <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>, and otherwise returns <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> only if all elements in <CodeContentPlaceHolder>423\</CodeContentPlaceHolder> <CodeContentPlaceHolder>424\</CodeContentPlaceHolder> are partitioned by <CodeContentPlaceHolder>425\</CodeContentPlaceHolder>; that is, all elements <CodeContentPlaceHolder>426\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>427\</CodeContentPlaceHolder> <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>429\</CodeContentPlaceHolder> is true occur before all elements <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>431\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>432\</CodeContentPlaceHolder>.  
  
##  \<a name="is_permutation">\</a>  is_permutation  
 Returns true if both ranges contain the same elements, whether or not the elements are in the same order. Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>  
 A forward iterator that refers to the first element of the range.  
  
 <CodeContentPlaceHolder>434\</CodeContentPlaceHolder>  
 A forward iterator that refers one past the last element of the range.  
  
 <CodeContentPlaceHolder>435\</CodeContentPlaceHolder>  
 A forward iterator that refers to the first element of a second range, used for comparison.  
  
 <CodeContentPlaceHolder>436\</CodeContentPlaceHolder>  
 A forward iterator that refers to one past the last element of a second range, used for comparison.  
  
 <CodeContentPlaceHolder>437\</CodeContentPlaceHolder>  
 A predicate that tests for equivalence and returns a <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> when the ranges can be rearranged so as to be identical according to the comparator predicate; otherwise, <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>441\</CodeContentPlaceHolder> has quadratic complexity in the worst case.  
  
 The first template function assumes that there are as many elements in the range beginning at <CodeContentPlaceHolder>442\</CodeContentPlaceHolder> as there are in the range designated by [ <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>). If there are more elements in the second range, they are ignored; if there are less, undefined behavior will occur. The third template function (C++14 and later) does not make this assumption.  Both return <CodeContentPlaceHolder>445\</CodeContentPlaceHolder> only if, for each element X in the range designated by [ <CodeContentPlaceHolder>446\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>) there are as many elements Y in the same range for which X == Y as there are in the range beginning at <CodeContentPlaceHolder>448\</CodeContentPlaceHolder> or [ <CodeContentPlaceHolder>449\</CodeContentPlaceHolder> Here, <CodeContentPlaceHolder>450\</CodeContentPlaceHolder> must perform a pairwise comparison between its operands.  
  
 The second and fourth template functions behave the same, except that they replace <CodeContentPlaceHolder>451\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>452\</CodeContentPlaceHolder>. To behave correctly, the predicate must be symmetric, reflexive and transitive.  
  
### Example  
  The following example shows how to use <CodeContentPlaceHolder>453\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
##  \<a name="is_sorted">\</a>  is_sorted  
 Returns <CodeContentPlaceHolder>454\</CodeContentPlaceHolder> if the elements in the specified range are in sorted order.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>455\</CodeContentPlaceHolder>  
 A forward iterator that indicates where the range to check begins.  
  
 <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns <CodeContentPlaceHolder>458\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>459\</CodeContentPlaceHolder>. This performs the same task as <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first template function returns [is_sorted_until](assetId:///bbad99d0-deaa-4fe6-ae58-eb5b3e4dded0)<CodeContentPlaceHolder>461\</CodeContentPlaceHolder> <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> <CodeContentPlaceHolder>463\</CodeContentPlaceHolder>. The operator< function performs the order comparison.  
  
 The second template function returns <CodeContentPlaceHolder>464\</CodeContentPlaceHolder> <CodeContentPlaceHolder>465\</CodeContentPlaceHolder> <CodeContentPlaceHolder>466\</CodeContentPlaceHolder> <CodeContentPlaceHolder>467\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>468\</CodeContentPlaceHolder> predicate function performs the order comparison.  
  
##  \<a name="is_sorted_until">\</a>  is_sorted_until  
 Returns a <CodeContentPlaceHolder>469\</CodeContentPlaceHolder> that is set to the last element that is in sorted order from a specified range.  
  
 The second version lets you provide a <CodeContentPlaceHolder>470\</CodeContentPlaceHolder> function that returns <CodeContentPlaceHolder>471\</CodeContentPlaceHolder> when two given elements are in sorted order, and <CodeContentPlaceHolder>472\</CodeContentPlaceHolder> otherwise.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>473\</CodeContentPlaceHolder>  
 A forward iterator that indicates where the range to check starts.  
  
 <CodeContentPlaceHolder>474\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns <CodeContentPlaceHolder>476\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>477\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>478\</CodeContentPlaceHolder> set to the last element in sorted order. The sorted sequence starts from <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first template function returns the last iterator <CodeContentPlaceHolder>480\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>481\</CodeContentPlaceHolder> <CodeContentPlaceHolder>482\</CodeContentPlaceHolder> so that <CodeContentPlaceHolder>483\</CodeContentPlaceHolder> is a sorted sequence ordered by <CodeContentPlaceHolder>484\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>485\</CodeContentPlaceHolder> <CodeContentPlaceHolder>486\</CodeContentPlaceHolder> the function returns <CodeContentPlaceHolder>487\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same, except that it replaces <CodeContentPlaceHolder>488\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>489\</CodeContentPlaceHolder>.  
  
##  \<a name="iter_swap">\</a>  iter_swap  
 Exchanges two values referred to by a pair of specified iterators.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>490\</CodeContentPlaceHolder>  
 One of the forward iterators whose value is to be exchanged.  
  
 <CodeContentPlaceHolder>491\</CodeContentPlaceHolder>  
 The second of the forward iterators whose value is to be exchanged.  
  
### Remarks  
 <CodeContentPlaceHolder>492\</CodeContentPlaceHolder> should be used in preference to i **ter_swap**, which was included in the C++ Standard for backward compatibility. If <CodeContentPlaceHolder>493\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>494\</CodeContentPlaceHolder> are forward iterators, then <CodeContentPlaceHolder>495\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>496\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>497\</CodeContentPlaceHolder> ), is equivalent to <CodeContentPlaceHolder>498\</CodeContentPlaceHolder> ( * <CodeContentPlaceHolder>499\</CodeContentPlaceHolder>, \* <CodeContentPlaceHolder>500\</CodeContentPlaceHolder> ).  
  
 The value types of the input forward iterators must have the same value.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **The original deque of CInts is deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**The deque of CInts with first & last elements swapped is:**  
 **deq1 = ( CInt(10), CInt(1), CInt(5) ).**  
**The deque of CInts with first & last elements swapped back is:**  
 **deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**Vector v1 is ( 0 1 2 3 ).**  
**Deque deq2 is ( 4 5 ).**  
**After exchanging first elements,**  
 **vector v1 is: v1 = ( 4 1 2 3 ).**  
 **& deque deq2 is: deq2 = ( 0 5 ).**    
##  \<a name="lexicographical_compare">\</a>  lexicographical_compare  
 Compares element by element between two sequences to determine which is lesser of the two.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>501\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be compared.  
  
 <CodeContentPlaceHolder>502\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first range to be compared.  
  
 <CodeContentPlaceHolder>503\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be compared.  
  
 <CodeContentPlaceHolder>504\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the second range to be compared.  
  
 <CodeContentPlaceHolder>505\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 **true** if the first range is lexicographically less than the second range; otherwise **false**.  
  
### Remarks  
 A lexicographical comparison between sequences compares them element by element until:  
  
-   It finds two corresponding elements unequal, and the result of their comparison is taken as the result of the comparison between sequences.  
  
-   No inequalities are found, but one sequence has more elements than the other, and the shorter sequence is considered less than the longer sequence.  
  
-   No inequalities are found and the sequences have the same number of elements, and so the sequences are equal and the result of the comparison is false.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 )**  
**List L1 = ( 0 5 10 15 20 25 30 )**  
**Vector v2 = ( 0 10 20 30 40 50 )**  
**Vector v1 is not lexicographically_less than v1.**  
**Vector v1 is lexicographically_less than L1.**  
**Vector v1 is not lexicographically_less than v2 under twice.**    
##  \<a name="lower_bound">\</a>  lower_bound  
 Finds the position of the first element in an ordered range that has a value greater than or equivalent to a specified value, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>506\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>507\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>508\</CodeContentPlaceHolder>  
 The value whose first position or possible first position is being searched for in the ordered range.  
  
 <CodeContentPlaceHolder>509\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator at the position of the first element in an ordered range with a value that is greater than or equivalent to a specified value, where the equivalence is specified with a binary predicate.  
  
### Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of using <CodeContentPlaceHolder>510\</CodeContentPlaceHolder> and where the ordering is the same as specified by with binary predicate.  
  
 The range is not modified by the algorithm <CodeContentPlaceHolder>511\</CodeContentPlaceHolder>.  
  
 The value types of the forward iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to ( <CodeContentPlaceHolder>512\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
##  \<a name="make_heap">\</a>  make_heap  
 Converts elements from a specified range into a heap in which the first element is the largest and for which a sorting criterion may be specified with a binary predicate.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>513\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>514\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>515\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The complexity is linear, requiring 3 \* (                        *_Last – _First*) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
##  \<a name="max">\</a>  max  
 Compares two objects and returns the larger of the two, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>516\</CodeContentPlaceHolder>  
 The first of the two objects being compared.  
  
 <CodeContentPlaceHolder>517\</CodeContentPlaceHolder>  
 The second of the two objects being compared.  
  
 <CodeContentPlaceHolder>518\</CodeContentPlaceHolder>  
 A binary predicate used to compare the two objects.  
  
 <CodeContentPlaceHolder>519\</CodeContentPlaceHolder>  
 The initializer list that contains the objects to be compared.  
  
### Return Value  
 The greater of the two objects, unless neither is greater; in that case, it returns the first of the two objects. In the case of an initializer_list, it returns the greatest of the objects in the list.  
  
### Remarks  
 The <CodeContentPlaceHolder>520\</CodeContentPlaceHolder> algorithm is unusual in having objects passed as parameters. Most Standard Template Library algorithms operate on a range of elements whose position is specified by iterators passed as parameters. If you need a function that operates on a range of elements, use [max_element](../vs140/-algorithm--functions.md#max_element) instead.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  **Using integers 6 and -7...**  
**The integer with the greater absolute value is: -7**  
**The integer with the greater value is: 6.**  
**Comparing the members of an initializer_list...The member with the greater value is: 6The integer wiht the greater absolute value is: -7**  
**s1 = ( CInt( 1 ), CInt( 2 ) ).**  
**s2 = ( CInt( 2 ), CInt( 3 ) ).**  
**s3 = max ( s1, s2 ) = ( CInt( 2 ), CInt( 3 ) ).**  
**Vector v1 is ( 0 1 2 ).**  
**Vector v2 is ( 0 1 2 ).**  
**Vector v3 is ( 0 2 4 ).**  
**Vector v4 = max (v1,v2) is ( 0 1 2 ).**  
**Vector v5 = max (v1,v3) is ( 0 2 4 ).**    
##  \<a name="max_element">\</a>  max_element  
 Finds the first occurrence of largest element in a specified range where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>521\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched for the largest element.  
  
 <CodeContentPlaceHolder>522\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched for the largest element.  
  
 <CodeContentPlaceHolder>523\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 A forward iterator addressing the position of the first occurrence of the largest element in the range searched.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear: ( <CodeContentPlaceHolder>524\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>525\</CodeContentPlaceHolder>) – 1 comparisons are required for a nonempty range.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
##  \<a name="merge">\</a>  merge  
 Combines all of the elements from two sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>526\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>527\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>528\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>529\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>530\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be combined into a single sorted range.  
  
 <CodeContentPlaceHolder>531\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range.  
  
### Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the **merge** algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range.  
  
 The complexity of the algorithm is linear with at most (                        *_Last1 – _First1*) – (                        *_Last2 – _First2*) – 1 comparisons.  
  
 The [list](../vs140/list-class.md) class provides a member function [merge](../vs140/list-class.md#list__merge) to merge the elements of two lists.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
##  \<a name="min">\</a>  min  
 Compares two objects and returns the lesser of the two, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>532\</CodeContentPlaceHolder>  
 The first of the two objects being compared.  
  
 <CodeContentPlaceHolder>533\</CodeContentPlaceHolder>  
 The second of the two objects being compared.  
  
 <CodeContentPlaceHolder>534\</CodeContentPlaceHolder>  
 A binary predicate used to compare the two objects.  
  
 <CodeContentPlaceHolder>535\</CodeContentPlaceHolder>  
 The initializer_list that contains the members to be compared.  
  
### Return Value  
 The lesser of the two objects, unless neither is lesser; in that case, it returns the first of the two objects. In the case of an initializer_list, it returns the least of the objects in the list.  
  
### Remarks  
 The <CodeContentPlaceHolder>536\</CodeContentPlaceHolder> algorithm is unusual in having objects passed as parameters. Most Standard Template Library algorithms operate on a range of elements whose position is specified by iterators passed as parameters. If you need a function that uses a range of elements, use [min_element](../vs140/-algorithm--functions.md#min_element).  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The mod_lesser of the integers 6 & -7 is: 6.**  
**The lesser of the integers -7 & 7 is: -7.**  
**The lesser of the integers 6 & 7 is: 6.The mod_lesser of the integers 6 & -7 is: 6.**  
**s1 = ( CInt( 1 ), CInt( 2 ) ).**  
**s2 = ( CInt( 2 ), CInt( 3 ) ).**  
**s3 = min ( s1, s2 ) = ( CInt( 1 ), CInt( 2 ) ).**  
**Vector v1 is ( 0 1 2 ).**  
**Vector v2 is ( 0 1 2 ).**  
**Vector v3 is ( 0 2 4 ).**  
**Vector v4 = min ( v1,v2 ) is ( 0 1 2 ).**  
**Vector v5 = min ( v1,v3 ) is ( 0 1 2 ).**    
##  \<a name="min_element">\</a>  min_element  
 Finds the first occurrence of smallest element in a specified range where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>537\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched for the smallest element.  
  
 <CodeContentPlaceHolder>538\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched for the smallest element.  
  
 <CodeContentPlaceHolder>539\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 A forward iterator addressing the position of the first occurrence of the smallest element in the range searched.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear: ( <CodeContentPlaceHolder>540\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>541\</CodeContentPlaceHolder>) – 1 comparisons are required for a nonempty range.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **s1 = ( CInt( -3 ), CInt( 1 ), CInt( 2 ) ).**  
**The smallest element in s1 is: CInt( -3 )**  
**Vector v1 is ( 0 1 2 3 -2 -4 -6 -8 ).**  
**The smallest element in v1 is: -8**  
**The smallest element in v1 under the mod_lesser**  
 **binary predicate is: 0**    
##  \<a name="minmax_element">\</a>  minmax_element  
 Performs the work performed by <CodeContentPlaceHolder>542\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>543\</CodeContentPlaceHolder> in one call.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>544\</CodeContentPlaceHolder>  
 A forward iterator that indicates the beginning of a range.  
  
 <CodeContentPlaceHolder>545\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>546\</CodeContentPlaceHolder>  
 An optional test used to order elements.  
  
### Return Value  
 Returns  
  
 <CodeContentPlaceHolder>547\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>548\</CodeContentPlaceHolder> [min_element](../vs140/-algorithm--functions.md#min_element)( <CodeContentPlaceHolder>549\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>550\</CodeContentPlaceHolder>), [max_element](../vs140/-algorithm--functions.md#max_element)( <CodeContentPlaceHolder>551\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>552\</CodeContentPlaceHolder>)).  
  
### Remarks  
 The first template function returns  
  
 <CodeContentPlaceHolder>553\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>554\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same, except that it replaces <CodeContentPlaceHolder>555\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>556\</CodeContentPlaceHolder>.  
  
 If the sequence is non-empty, the function performs at most <CodeContentPlaceHolder>557\</CodeContentPlaceHolder> <CodeContentPlaceHolder>558\</CodeContentPlaceHolder> <CodeContentPlaceHolder>559\</CodeContentPlaceHolder> <CodeContentPlaceHolder>560\</CodeContentPlaceHolder> comparisons.  
  
##  \<a name="minmax">\</a>  minmax  
 Compares two input parameters and returns them as a pair, in order of lesser to greater.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>561\</CodeContentPlaceHolder>  
 The first of the two objects being compared.  
  
 <CodeContentPlaceHolder>562\</CodeContentPlaceHolder>  
 The second of the two objects being compared.  
  
 <CodeContentPlaceHolder>563\</CodeContentPlaceHolder>  
 A binary predicate used to compare the two objects.  
  
 <CodeContentPlaceHolder>564\</CodeContentPlaceHolder>  
 The initializer_list that contains the members to be compared.  
  
### Remarks  
 The first template function returns <CodeContentPlaceHolder>565\</CodeContentPlaceHolder> <CodeContentPlaceHolder>566\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>567\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>568\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>569\</CodeContentPlaceHolder> <CodeContentPlaceHolder>570\</CodeContentPlaceHolder>.  
  
 The second member function returns a pair where the first element is the lesser and the second is the greater when compared by the predicate <CodeContentPlaceHolder>571\</CodeContentPlaceHolder>.  
  
 The remaining template functions behave the same, except that they replace the <CodeContentPlaceHolder>572\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>573\</CodeContentPlaceHolder> parameters with <CodeContentPlaceHolder>574\</CodeContentPlaceHolder>.  
  
 The function performs exactly one comparison.  
  
##  \<a name="mismatch">\</a>  mismatch  
 Compares two ranges element by element and locates the first position where a difference occurs.  
  
 Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>575\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be tested.  
  
 <CodeContentPlaceHolder>576\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first range to be tested.  
  
 <CodeContentPlaceHolder>577\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be tested.  
  
 <CodeContentPlaceHolder>578\</CodeContentPlaceHolder>  
 An input iterator addressing the position of one past the last element in the second range to be tested.  
  
 <CodeContentPlaceHolder>579\</CodeContentPlaceHolder>  
 User-defined predicate function object that compares the current elements in each range and determines whether they are equivalent. It returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A pair of iterators addressing the positions of the mismatch in the two ranges, the first component iterator to the position in the first range and the second component iterator to the position in the second range. If there is no difference between the elements in the ranges compared or if the binary predicate in the second version is satisfied by all element pairs from the two ranges, then the first component iterator points to the position one past the final element in the first range and the second component iterator to position one past the final element tested in the second range.  
  
### Remarks  
 The first template function assumes that there are as many elements in the range beginning at first2 as there are in the range designated by [first1, last1). If there are more in the second range, they are ignored; if there are less then undefined behavior will result.  
  
 The range to be searched must be valid; all iterators must be dereferenceable and the last position is reachable from the first by incrementation.  
  
 The time complexity of the algorithm is linear in the number of elements contained in the shorter range.  
  
 The user-defined predicate is not required to impose an equivalence relation that symmetric, reflexive and transitive between its operands.  
  
### Example  
  The following example demonstrates how to use mismatch. The C++03 overload is shown only in order to demonstrate how it can produce an unexpected result.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
##  \<a name="alg_move">\</a>  &lt;alg&gt; move  
 Move elements associated with a specified range.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>580\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start the range of elements to move.  
  
 <CodeContentPlaceHolder>581\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range of elements to move.  
  
 <CodeContentPlaceHolder>582\</CodeContentPlaceHolder>  
 The output iterator that is to contain the moved elements.  
  
### Remarks  
 The template function evaluates <CodeContentPlaceHolder>583\</CodeContentPlaceHolder> <CodeContentPlaceHolder>584\</CodeContentPlaceHolder>  move <CodeContentPlaceHolder>585\</CodeContentPlaceHolder> <CodeContentPlaceHolder>586\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>587\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>588\</CodeContentPlaceHolder> <CodeContentPlaceHolder>589\</CodeContentPlaceHolder> <CodeContentPlaceHolder>590\</CodeContentPlaceHolder> <CodeContentPlaceHolder>591\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>592\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>593\</CodeContentPlaceHolder> <CodeContentPlaceHolder>594\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>595\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>596\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>597\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>598\</CodeContentPlaceHolder> <CodeContentPlaceHolder>599\</CodeContentPlaceHolder>.  
  
##  \<a name="move_backward">\</a>  move_backward  
 Moves the elements of one iterator to another. The move starts with the last element in a specified range, and ends with the first element in that range.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>600\</CodeContentPlaceHolder>  
 An iterator that indicates the start of a range to move elements from.  
  
 <CodeContentPlaceHolder>601\</CodeContentPlaceHolder>  
 An iterator that indicates the end of a range to move elements from. This element is not moved.  
  
 <CodeContentPlaceHolder>602\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
### Remarks  
 The template function evaluates <CodeContentPlaceHolder>603\</CodeContentPlaceHolder> <CodeContentPlaceHolder>604\</CodeContentPlaceHolder> <CodeContentPlaceHolder>605\</CodeContentPlaceHolder> <CodeContentPlaceHolder>606\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>607\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>608\</CodeContentPlaceHolder> <CodeContentPlaceHolder>609\</CodeContentPlaceHolder> <CodeContentPlaceHolder>610\</CodeContentPlaceHolder> <CodeContentPlaceHolder>611\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>612\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>613\</CodeContentPlaceHolder> <CodeContentPlaceHolder>614\</CodeContentPlaceHolder> <CodeContentPlaceHolder>615\</CodeContentPlaceHolder> <CodeContentPlaceHolder>616\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>617\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>618\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>619\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>620\</CodeContentPlaceHolder> <CodeContentPlaceHolder>621\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>622\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>623\</CodeContentPlaceHolder> are functionally equivalent to using <CodeContentPlaceHolder>624\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>625\</CodeContentPlaceHolder> with a move iterator.  
  
##  \<a name="next_permutation">\</a>  next_permutation  
 Reorders the elements in a range so that the original ordering is replaced by the lexicographically next greater permutation if it exists, where the sense of next may be specified with a binary predicate.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>626\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the range to be permuted.  
  
 <CodeContentPlaceHolder>627\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the range to be permuted.  
  
 <CodeContentPlaceHolder>628\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 **true** if the lexicographically next permutation exists and has replaced the original ordering of the range; otherwise **false**, in which case the ordering is transformed into the lexicographically smallest permutation.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The default binary predicate is less than and the elements in the range must be less than comparable to insure that the next permutation is well defined.  
  
 The complexity is linear with at most (                        *_Last – _First*)/2 swaps.  
  
### Example  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  **The original deque of CInts is deq1 = ( CInt( 5 ), CInt( 1 ), CInt( 10 ) ).**  
**The lexicographically next permutation exists and has**  
**replaced the original ordering of the sequence in deq1.**  
**After one application of next_permutation,**  
 **deq1 = ( CInt( 5 ), CInt( 10 ), CInt( 1 ) ).**  
**Vector v1 is ( -3 -2 -1 0 1 2 3 ).**  
**After the first next_permutation, vector v1 is:**  
 **v1 = ( -3 -2 -1 0 1 3 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 1 3 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 3 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 1 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 2 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 1 0 2 3 ).**    
##  \<a name="nth_element">\</a>  nth_element  
 Partitions a range of elements, correctly locating the                 *n*th element of the sequence in the range so that all the elements in front of it are less than or equal to it and all the elements that follow it in the sequence are greater than or equal to it.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>629\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be partitioned.  
  
 *_Nth*  
 A random-access iterator addressing the position of element to be correctly ordered on the boundary of the partition.  
  
 <CodeContentPlaceHolder>630\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>631\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The <CodeContentPlaceHolder>632\</CodeContentPlaceHolder> algorithm does not guarantee that elements in the sub-ranges either side of the                         *n*th element are sorted. It thus makes fewer guarantees than <CodeContentPlaceHolder>633\</CodeContentPlaceHolder>, which orders the elements in the range below some chosen element, and may be used as a faster alternative to <CodeContentPlaceHolder>634\</CodeContentPlaceHolder> when the ordering of the lower range is not required.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other.  
  
 The average of a sort complexity is linear with respect to                         *_Last – _First*.  
  
### Example  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
##  \<a name="none_of">\</a>  none_of  
 Returns <CodeContentPlaceHolder>635\</CodeContentPlaceHolder> when a condition is never present among elements in the given range.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>636\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start to check a range of elements for a condition.  
  
 <CodeContentPlaceHolder>637\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range of elements.  
  
 <CodeContentPlaceHolder>638\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition. A predicate takes a single argument and returns <CodeContentPlaceHolder>639\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>640\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>641\</CodeContentPlaceHolder> if the condition is not detected at least once in the indicated range, and <CodeContentPlaceHolder>642\</CodeContentPlaceHolder> if the condition is detected.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>643\</CodeContentPlaceHolder> only if, for some <CodeContentPlaceHolder>644\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>645\</CodeContentPlaceHolder> <CodeContentPlaceHolder>646\</CodeContentPlaceHolder> <CodeContentPlaceHolder>647\</CodeContentPlaceHolder> <CodeContentPlaceHolder>648\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>649\</CodeContentPlaceHolder> <CodeContentPlaceHolder>650\</CodeContentPlaceHolder> is always <CodeContentPlaceHolder>651\</CodeContentPlaceHolder>.  
  
##  \<a name="partial_sort">\</a>  partial_sort  
 Arranges a specified number of the smaller elements in a range into a nondescending order or according to an ordering criterion specified by a binary predicate.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>652\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>653\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the subrange to be sorted.  
  
 <CodeContentPlaceHolder>654\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be partially sorted.  
  
 <CodeContentPlaceHolder>655\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The **sort** algorithm is not stable and does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm <CodeContentPlaceHolder>656\</CodeContentPlaceHolder> does preserve this original ordering.  
  
 The average partial sort complexity is                         *O*(( <CodeContentPlaceHolder>657\</CodeContentPlaceHolder>- <CodeContentPlaceHolder>658\</CodeContentPlaceHolder>) log ( <CodeContentPlaceHolder>659\</CodeContentPlaceHolder>- <CodeContentPlaceHolder>660\</CodeContentPlaceHolder>)).  
  
### Example  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  **Original vector:**  
 **v1 = ( 0 2 4 6 8 10 1 3 5 7 9 11 )**  
**Partially sorted vector:**  
 **v1 = ( 0 1 2 3 4 5 10 8 6 7 9 11 )**  
**Partially resorted (greater) vector:**  
 **v1 = ( 11 10 9 8 0 1 2 3 4 5 6 7 )**  
**Partially resorted (UDgreater) vector:**  
 **v1 = ( 11 10 9 8 7 6 5 4 0 1 2 3 )**    
##  \<a name="partial_sort_copy">\</a>  partial_sort_copy  
 Copies elements from a source range into a destination range where the source elements are ordered by either less than or another specified binary predicate.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>661\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>662\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the source range.  
  
 <CodeContentPlaceHolder>663\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the sorted destination range.  
  
 <CodeContentPlaceHolder>664\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the sorted destination range.  
  
 <CodeContentPlaceHolder>665\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>666\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>667\</CodeContentPlaceHolder> when not satisfied.  
  
### Return Value  
 A random-access iterator addressing the element in the destination range one position beyond the last element inserted from the source range.  
  
### Remarks  
 The source and destination ranges must not overlap and must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The binary predicate must provide a strict weak ordering so that elements that are not equivalent are ordered, but elements that are equivalent are not. Two elements are equivalent under less than, but not necessarily equal, if neither is less than the other.  
  
### Example  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
##  \<a name="partition">\</a>  partition  
 Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>668\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>669\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the final element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>670\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be classified. A predicate takes a single argument and returns **true** or **false**.  
  
### Return Value  
 A bidirectional iterator addressing the position of the first element in the range to not satisfy the predicate condition.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements                         *a* and                         *b* are equivalent, but not necessarily equal, if both                         *Pr* (                        *a*,                         *b*) is false and                         *Pr* (                        *b*,                         *a*) if false, where                         *Pr* is the parameter-specified predicate. The **partition** algorithm is not stable and does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm **stable_ partition** does preserve this original ordering.  
  
 The complexity is linear: there are ( <CodeContentPlaceHolder>671\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>672\</CodeContentPlaceHolder>) applications of <CodeContentPlaceHolder>673\</CodeContentPlaceHolder> and at most ( <CodeContentPlaceHolder>674\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>675\</CodeContentPlaceHolder>)/2 swaps.  
  
### Example  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
##  \<a name="partition_copy">\</a>  partition_copy  
 Copies elements for which a condition is <CodeContentPlaceHolder>676\</CodeContentPlaceHolder> to one destination, and for which the condition is <CodeContentPlaceHolder>677\</CodeContentPlaceHolder> to another. The elements must come from a specified range.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>678\</CodeContentPlaceHolder>  
 An input iterator that indicates the beginning of a range to check for a condition.  
  
 <CodeContentPlaceHolder>679\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>680\</CodeContentPlaceHolder>  
 An output iterator used to copy elements that return true for a condition tested by using <CodeContentPlaceHolder>681\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>682\</CodeContentPlaceHolder>  
 An output iterator used to copy elements that return false for a condition tested by using <CodeContentPlaceHolder>683\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>684\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be tested. A predicate takes a single argument and returns <CodeContentPlaceHolder>685\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>686\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function copies each element <CodeContentPlaceHolder>687\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>688\</CodeContentPlaceHolder> <CodeContentPlaceHolder>689\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>690\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>691\</CodeContentPlaceHolder> is true, or to <CodeContentPlaceHolder>692\</CodeContentPlaceHolder>. It returns <CodeContentPlaceHolder>693\</CodeContentPlaceHolder> <CodeContentPlaceHolder>694\</CodeContentPlaceHolder>.  
  
##  \<a name="partition_point">\</a>  partition_point  
 Returns the first element in the given range that does not satisfy the condition. The elements are sorted so that those that satisfy the condition come before those that do not.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>695\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>696\</CodeContentPlaceHolder> that indicates the start of a range to check for a condition.  
  
 <CodeContentPlaceHolder>697\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>698\</CodeContentPlaceHolder> that indicates the end of a range.  
  
 <CodeContentPlaceHolder>699\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns <CodeContentPlaceHolder>700\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>701\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>702\</CodeContentPlaceHolder> that refers to the first element that does not fulfill the condition tested for by <CodeContentPlaceHolder>703\</CodeContentPlaceHolder>, or returns <CodeContentPlaceHolder>704\</CodeContentPlaceHolder> if one is not found.  
  
### Remarks  
 The template function finds the first iterator <CodeContentPlaceHolder>705\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>706\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>707\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>708\</CodeContentPlaceHolder>. The sequence must be ordered by <CodeContentPlaceHolder>709\</CodeContentPlaceHolder>.  
  
##  \<a name="pop_heap">\</a>  pop_heap  
 Removes the largest element from the front of a heap to the next-to-last position in the range and then forms a new heap from the remaining elements.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>710\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the heap.  
  
 <CodeContentPlaceHolder>711\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the heap.  
  
 <CodeContentPlaceHolder>712\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 The <CodeContentPlaceHolder>713\</CodeContentPlaceHolder> algorithm is the inverse of the operation performed by the push_heap algorithm, in which an element at the next-to-last position of a range is added to a heap consisting of the prior elements in the range, in the case when the element being added to the heap is larger than any of the elements already in the heap.  
  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The range excluding the newly added element at the end must be a heap.  
  
 The complexity is logarithmic, requiring at most log (                        *_Last – _First*) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
##  \<a name="prev_permutation">\</a>  prev_permutation  
 Reorders the elements in a range so that the original ordering is replaced by the lexicographically previous greater permutation if it exists, where the sense of previous may be specified with a binary predicate.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>714\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the range to be permuted.  
  
 <CodeContentPlaceHolder>715\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the range to be permuted.  
  
 <CodeContentPlaceHolder>716\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>717\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>718\</CodeContentPlaceHolder> when not satisfied.  
  
### Return Value  
 <CodeContentPlaceHolder>719\</CodeContentPlaceHolder> if the lexicographically previous permutation exists and has replaced the original ordering of the range; otherwise <CodeContentPlaceHolder>720\</CodeContentPlaceHolder>, in which case the ordering is transformed into the lexicographically largest permutation.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The default binary predicate is less than and the elements in the range must be less-than comparable to ensure that the previous permutation is well defined.  
  
 The complexity is linear, with at most ( <CodeContentPlaceHolder>721\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>722\</CodeContentPlaceHolder>)/2 swaps.  
  
### Example  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  **The original deque of CInts is deq1 = ( CInt( 1 ), CInt( 5 ), CInt( 10 ) ).**  
**The lexicographically previous permutation doesn't exist**  
 **and the lexicographically smallest permutation**  
 **has replaced the original ordering of the sequence in deq1.**  
**After one application of prev_permutation,**  
 **deq1 = ( CInt( 10 ), CInt( 5 ), CInt( 1 ) ).**  
**Vector v1 is ( -3 -2 -1 0 1 2 3 ).**  
**After the first prev_permutation, vector v1 is:**  
 **v1 = ( -3 -2 0 3 2 1 -1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 3 -1 2 1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 3 -1 1 2 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 3 1 -1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 -1 3 1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 -1 1 3 ).**    
##  \<a name="push_heap">\</a>  push_heap  
 Adds an element that is at the end of a range to an existing heap consisting of the prior elements in the range.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>723\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the heap.  
  
 <CodeContentPlaceHolder>724\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>725\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 The element must first be pushed back to the end of an existing heap and then the algorithm is used to add this element to the existing heap.  
  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The range excluding the newly added element at the end must be a heap.  
  
 The complexity is logarithmic, requiring at most log (                        *_Last – _First*) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
##  \<a name="random_shuffle">\</a>  random_shuffle  
 The std::random_shuffle() function is deprecated, replaced by [std::shuffle()](../vs140/-algorithm--functions.md#std__shuffle). For a code example and more information, see [\<random>](../vs140/-random-.md) and the Stackoverflow posting                 [Why are std::random_shuffle methods being deprecated in C++14?](http://go.microsoft.com/fwlink/?LinkId=397954).  
  
##  \<a name="remove">\</a>  remove  
 Eliminates a specified value from a given range without disturbing the order of the remaining elements and returning the end of a new range free of the specified value.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>726\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>727\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>728\</CodeContentPlaceHolder>  
 The value that is to be removed from the range.  
  
### Return Value  
 A forward iterator addressing the new end position of the modified range, one past the final element of the remnant sequence free of the specified value.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>729\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are ( <CodeContentPlaceHolder>730\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>731\</CodeContentPlaceHolder>) comparisons for equality.  
  
 The [list](../vs140/list-class.md) class has a more efficient member function version of **remove**, which also relinks pointers.  
  
### Example  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
##  \<a name="remove_copy">\</a>  remove_copy  
 Copies elements from a source range to a destination range, except that elements of a specified value are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>732\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>733\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>734\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range to which elements are being removed.  
  
 <CodeContentPlaceHolder>735\</CodeContentPlaceHolder>  
 The value that is to be removed from the range.  
  
### Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the copy of the remnant sequence free of the specified value.  
  
### Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>736\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are ( <CodeContentPlaceHolder>737\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>738\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>739\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>740\</CodeContentPlaceHolder>) assignments.  
  
### Example  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
##  \<a name="remove_copy_if">\</a>  remove_copy_if  
 Copies elements from a source range to a destination range, except that satisfying a predicate are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>741\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>742\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>743\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range to which elements are being removed.  
  
 <CodeContentPlaceHolder>744\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
### Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the remnant sequence free of the elements satisfying the predicate.  
  
### Remarks  
 The source range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>745\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are ( <CodeContentPlaceHolder>746\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>747\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>748\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>749\</CodeContentPlaceHolder>) assignments.  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
##  \<a name="remove_if">\</a>  remove_if  
 Eliminates elements that satisfy a predicate from a given range without disturbing the order of the remaining elements and returning the end of a new range free of the specified value.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>750\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>751\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>752\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
### Return Value  
 A forward iterator addressing the new end position of the modified range, one past the final element of the remnant sequence free of the specified value.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>753\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are ( <CodeContentPlaceHolder>754\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>755\</CodeContentPlaceHolder>) comparisons for equality.  
  
 List has a more efficient member function version of remove which relinks pointers.  
  
### Example  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
##  \<a name="replace">\</a>  replace  
 Examines each element in a range and replaces it if it matches a specified value.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>756\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>757\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>758\</CodeContentPlaceHolder>  
 The old value of the elements being replaced.  
  
 <CodeContentPlaceHolder>759\</CodeContentPlaceHolder>  
 The new value being assigned to the elements with the old value.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>760\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are ( <CodeContentPlaceHolder>761\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>762\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>763\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>764\</CodeContentPlaceHolder>) assignments of new values.  
  
### Example  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
##  \<a name="replace_copy">\</a>  replace_copy  
 Examines each element in a source range and replaces it if it matches a specified value while copying the result into a new destination range.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>765\</CodeContentPlaceHolder>  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>766\</CodeContentPlaceHolder>  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>767\</CodeContentPlaceHolder>  
 An output iterator pointing to the first element in the destination range to where the altered sequence of elements is being copied.  
  
 <CodeContentPlaceHolder>768\</CodeContentPlaceHolder>  
 The old value of the elements being replaced.  
  
 <CodeContentPlaceHolder>769\</CodeContentPlaceHolder>  
 The new value being assigned to the elements with the old value.  
  
### Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
### Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>770\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are ( <CodeContentPlaceHolder>771\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>772\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>773\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>774\</CodeContentPlaceHolder>) assignments of new values.  
  
### Example  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
##  \<a name="replace_copy_if">\</a>  replace_copy_if  
 Examines each element in a source range and replaces it if it satisfies a specified predicate while copying the result into a new destination range.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>775\</CodeContentPlaceHolder>  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>776\</CodeContentPlaceHolder>  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>777\</CodeContentPlaceHolder>  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
 <CodeContentPlaceHolder>778\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 <CodeContentPlaceHolder>779\</CodeContentPlaceHolder>  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
### Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
### Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>780\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are ( <CodeContentPlaceHolder>781\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>782\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>783\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>784\</CodeContentPlaceHolder>) assignments of new values.  
  
### Example  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
##  \<a name="replace_if">\</a>  replace_if  
 Examines each element in a range and replaces it if it satisfies a specified predicate.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>785\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>786\</CodeContentPlaceHolder>  
 An iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>787\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 <CodeContentPlaceHolder>788\</CodeContentPlaceHolder>  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The algorithm <CodeContentPlaceHolder>789\</CodeContentPlaceHolder> is a generalization of the algorithm **replace**, allowing any predicate to be specified, rather than equality to a specified constant value.  
  
 The <CodeContentPlaceHolder>790\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are ( <CodeContentPlaceHolder>791\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>792\</CodeContentPlaceHolder>) comparisons for equality and at most ( <CodeContentPlaceHolder>793\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>794\</CodeContentPlaceHolder>) assignments of new values.  
  
### Example  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
##  \<a name="reverse">\</a>  reverse  
 Reverses the order of the elements within a range.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>795\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the range within which the elements are being permuted.  
  
 <CodeContentPlaceHolder>796\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the range within which the elements are being permuted.  
  
### Remarks  
 The source range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
### Example  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 0 1 2 3 4 5 6 7 8 9 ).**  
**The modified vector v1 with values reversed is:**  
 **( 9 8 7 6 5 4 3 2 1 0 ).**    
##  \<a name="reverse_copy">\</a>  reverse_copy  
 Reverses the order of the elements within a source range while copying them into a destination range  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>797\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the source range within which the elements are being permuted.  
  
 <CodeContentPlaceHolder>798\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the source range within which the elements are being permuted.  
  
 <CodeContentPlaceHolder>799\</CodeContentPlaceHolder>  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
### Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
### Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
### Example  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
##  \<a name="rotate">\</a>  rotate  
 Exchanges the elements in two adjacent ranges.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>800\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be rotated.  
  
 <CodeContentPlaceHolder>801\</CodeContentPlaceHolder>  
 A forward iterator defining the boundary within the range that addresses the position of the first element in the second part of the range whose elements are to be exchanged with those in the first part of the range.  
  
 _ <CodeContentPlaceHolder>802\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be rotated.  
  
### Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear with at most ( <CodeContentPlaceHolder>803\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>804\</CodeContentPlaceHolder>) swaps.  
  
### Example  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  **Vector v1 is ( -3 -2 -1 0 1 2 3 4 5 ).**  
**After rotating, vector v1 is ( 0 1 2 3 4 5 -3 -2 -1 ).**  
**The original deque d1 is ( 0 1 2 3 4 5 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 1 2 3 4 5 0 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 2 3 4 5 0 1 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 3 4 5 0 1 2 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 4 5 0 1 2 3 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 5 0 1 2 3 4 ).**  
**After the rotation of a single deque element to the back,**  
 **d1 is   ( 0 1 2 3 4 5 ).**    
##  \<a name="rotate_copy">\</a>  rotate_copy  
 Exchanges the elements in two adjacent ranges within a source range and copies the result to a destination range.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>805\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be rotated.  
  
 <CodeContentPlaceHolder>806\</CodeContentPlaceHolder>  
 A forward iterator defining the boundary within the range that addresses the position of the first element in the second part of the range whose elements are to be exchanged with those in the first part of the range.  
  
 _ <CodeContentPlaceHolder>807\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be rotated.  
  
 <CodeContentPlaceHolder>808\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
### Return Value  
 An output iterator addressing the position one past the final element in the destination range.  
  
### Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear with at most ( <CodeContentPlaceHolder>809\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>810\</CodeContentPlaceHolder>) swaps.  
  
### Example  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
##  \<a name="search">\</a>  search  
 Searches for the first occurrence of a sequence within a target range whose elements are equal to those in a given sequence of elements or whose elements are equivalent in a sense specified by a binary predicate to the elements in the given sequence.  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>811\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>812\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>813\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be matched.  
  
 <CodeContentPlaceHolder>814\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be matched.  
  
 <CodeContentPlaceHolder>815\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
### Remarks  
 The <CodeContentPlaceHolder>816\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 Average complexity is linear with respect to the size of the searched range, and worst case complexity is also linear with respect to the size of the sequence being searched for.  
  
### Example  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 20 25 )**  
**Vector v2 = ( 20 30 40 )**  
**There is at least one match of L1 in v1**  
 **and the first one begins at position 4.**  
**There is a sequence of elements in v1 that are equivalent**  
 **to those in v2 under the binary predicate twice**  
 **and the first one begins at position 2.**    
##  \<a name="search_n">\</a>  search_n  
 Searches for the first subsequence in a range that of a specified number of elements having a particular value or a relation to that value as specified by a binary predicate.  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>817\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>818\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>819\</CodeContentPlaceHolder>  
 The size of the subsequence being searched for.  
  
 <CodeContentPlaceHolder>820\</CodeContentPlaceHolder>  
 The value of the elements in the sequence being searched for.  
  
 <CodeContentPlaceHolder>821\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
### Remarks  
 The <CodeContentPlaceHolder>822\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Complexity is linear with respect to the size of the searched.  
  
### Example  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  **Vector v1 = ( 0 5 10 15 20 25 5 5 5 0 5 10 15 20 25 10 10 10 )**  
**There is at least one match of a sequence ( 5 5 5 )**  
 **in v1 and the first one begins at position 6.**  
**There is a match of a sequence ( 5 5 5 ) under the equivalence**  
 **predicate one_half in v1 and the first one begins at position 15.**    
##  \<a name="set_difference">\</a>  set_difference  
 Unites all of the elements that belong to one sorted source range, but not to a second sorted source range, into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>823\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>824\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>825\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>826\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>827\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>828\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the difference of the two source ranges.  
  
### Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the first source range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>829\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm merge.  
  
 The value types of the input iterators need be less-than-comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element such that there are more in the first source range than in the second, then the destination range will contain the number by which the occurrences of those elements in the first source range exceed the occurrences of those elements in the second source range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (                        *last1 – first1*) – (                        *last2 – first2*) ) – 1 comparisons for nonempty source ranges.  
  
### Example  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
##  \<a name="set_intersection">\</a>  set_intersection  
 Unites all of the elements that belong to both sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>830\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the intersection of the two source ranges.  
  
 <CodeContentPlaceHolder>831\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the intersection of the two source ranges.  
  
 <CodeContentPlaceHolder>832\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the intersection of the two source ranges.  
  
 <CodeContentPlaceHolder>833\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the intersection of the two source ranges.  
  
 **_** *Result*  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the intersection of the two source ranges.  
  
 <CodeContentPlaceHolder>834\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the intersection of the two source ranges.  
  
### Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the merge algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element, then the destination range will contain the maximum number of those elements that occur in both source ranges.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (                        *_Last1 – _First1*) + (                        *_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
### Example  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
##  \<a name="set_symmetric_difference">\</a>  set_symmetric_difference  
 Unites all of the elements that belong to one, but not both, of the sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>835\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 <CodeContentPlaceHolder>836\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 <CodeContentPlaceHolder>837\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 <CodeContentPlaceHolder>838\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the symmetric difference of the two source ranges.  
  
 **_** *Result*  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the symmetric difference of the two source ranges.  
  
 <CodeContentPlaceHolder>839\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the symmetric difference of the two source ranges.  
  
### Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the **merge** algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm merge.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element, then the destination range will contain the absolute value of the number by which the occurrences of those elements in the one of the source ranges exceeds the occurrences of those elements in the second source range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (                        *_Last1 – _First1*) – (                        *_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
### Example  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
##  \<a name="set_union">\</a>  set_union  
 Unites all of the elements that belong to at least one of two sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>840\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the union of the two source ranges.  
  
 <CodeContentPlaceHolder>841\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the union of the two source ranges.  
  
 <CodeContentPlaceHolder>842\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the union of the two source ranges.  
  
 <CodeContentPlaceHolder>843\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the union of the two source ranges.  
  
 **_** *Result*  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the union of the two source ranges.  
  
 <CodeContentPlaceHolder>844\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
### Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the union of the two source ranges.  
  
### Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the destination range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the **merge** algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element, then the destination range will contain the maximum number of those elements that occur in both source ranges.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (                        *_Last1 – _First1*) – (                        *_Last2 – _First2*) ) – 1 comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
##  \<a name="std__shuffle">\</a>  std::shuffle  
 Shuffles (rearranges) elements for a given range by using a random number generator.  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>845\</CodeContentPlaceHolder>  
 An iterator to the first element in the range to be shuffled, inclusive. Must meet the requirements of <CodeContentPlaceHolder>846\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>847\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>848\</CodeContentPlaceHolder>  
 An iterator to the last element in the range to be shuffled, exclusive. Must meet the requirements of <CodeContentPlaceHolder>849\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>850\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>851\</CodeContentPlaceHolder>  
 The random number generator that the <CodeContentPlaceHolder>852\</CodeContentPlaceHolder> function will use for the operation. Must meet the requirements of a <CodeContentPlaceHolder>853\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, and a code sample that uses <CodeContentPlaceHolder>854\</CodeContentPlaceHolder>, see [\<random>](../vs140/-random-.md).  
  
##  \<a name="sort">\</a>  sort  
 Arranges the elements in a specified range into a nondescending order or according to an ordering criterion specified by a binary predicate.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>855\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>856\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>857\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. This binary predicate takes two arguments and returns <CodeContentPlaceHolder>858\</CodeContentPlaceHolder> if the two arguments are in order and <CodeContentPlaceHolder>859\</CodeContentPlaceHolder> otherwise. This comparator function must impose a strict weak ordering on pairs of elements from the sequence. For more information, see [Algorithms](../vs140/algorithms.md).  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The <CodeContentPlaceHolder>860\</CodeContentPlaceHolder> algorithm is not stable and so does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm <CodeContentPlaceHolder>861\</CodeContentPlaceHolder> does preserve this original ordering.  
  
 The average of a sort complexity is                         *O*(                        *N* log                         *N*), where                         *N* =                         *last – first*.  
  
### Example  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  **Original vector v1 = ( 0 2 4 6 8 10 1 3 5 7 9 11 )**  
**Sorted vector v1 = ( 0 1 2 3 4 5 6 7 8 9 10 11 )**  
**Resorted (greater) vector v1 = ( 11 10 9 8 7 6 5 4 3 2 1 0 )**  
**Resorted (UDgreater) vector v1 = ( 11 10 9 8 7 6 5 4 3 2 1 0 )**    
##  \<a name="sort_heap">\</a>  sort_heap  
 Converts a heap into a sorted range.  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>862\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the target heap.  
  
 <CodeContentPlaceHolder>863\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the target heap.  
  
 <CodeContentPlaceHolder>864\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 After the application if this algorithm, the range it was applied to is no longer a heap.  
  
 This is not a stable sort because the relative order of equivalent elements is not necessarily preserved.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is at most                         *N* log                         *N*, where                         *N* = (                        *_Last – _First*).  
  
### Example  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
##  \<a name="stable_partition">\</a>  stable_partition  
 Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it, preserving the relative order of equivalent elements.  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>865\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>866\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the final element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>867\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be classified. A predicate takes single argument and returns **true** or **false**.  
  
### Return Value  
 A bidirectional iterator addressing the position of the first element in the range to not satisfy the predicate condition.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements                         *a* and                         *b* are equivalent, but not necessarily equal, if both                         *Pr* (                        *a*,                         *b*) is false and                         *Pr* (                        *b*,                         *a*) if false, where                         *Pr* is the parameter-specified predicate. The **stable_ partition** algorithm is stable and guarantees that the relative ordering of equivalent elements will be preserved. The algorithm **partition** does not necessarily preserve this original ordering.  
  
### Example  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
##  \<a name="stable_sort">\</a>  stable_sort  
 Arranges the elements in a specified range into a nondescending order or according to an ordering criterion specified by a binary predicate and preserves the relative ordering of equivalent elements.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>868\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>869\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>870\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The **sort** algorithm is stable and guarantees that the relative ordering of equivalent elements will be preserved.  
  
 The run-time complexity of <CodeContentPlaceHolder>871\</CodeContentPlaceHolder> depends on the amount of memory available, but the best case (given sufficient memory) is                         *O*(                        *N* log                         *N*) and the worst case is                         *O*(                         *N* ( log                         *N* )2 ), where                         *N* =                         *_Last – First.* Usually, the **sort** algorithm is significantly faster than <CodeContentPlaceHolder>872\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
  **Original vector v1 = ( 0 2 4 6 8 10 0 2 4 6 8 10 )**  
**Sorted vector v1 = ( 0 0 2 2 4 4 6 6 8 8 10 10 )**  
**Resorted (greater) vector v1 = ( 10 10 8 8 6 6 4 4 2 2 0 0 )**  
**Resorted (UDgreater) vector v1 = ( 10 10 8 8 6 6 4 4 2 2 0 0 )**    
##  \<a name="swap">\</a>  swap  
 The first override exchanges the values of two objects. The second override exchanges the values between two arrays of objects.  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>873\</CodeContentPlaceHolder>  
 For the first override, the first object to have its contents exchanged. For the second override, the first array of objects to have its contents exchanged.  
  
 <CodeContentPlaceHolder>874\</CodeContentPlaceHolder>  
 For the first override, the second object to have its contents exchanged. For the second override, the second array of objects to have its contents exchanged.  
  
### Remarks  
 The first overload is designed to operate on individual objects. The second overload swaps the contents of objects between two arrays.  
  
### Example  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
  **Vector v1 is ( 0 1 2 3 4 5 6 7 8 9 10 ).**  
**Vector v2 is ( 5 5 5 5 5 ).**  
**Vector v1 is ( 5 5 5 5 5 ).**  
**Vector v2 is ( 0 1 2 3 4 5 6 7 8 9 10 ).**    
##  \<a name="swap_ranges">\</a>  swap_ranges  
 Exchanges the elements of one range with the elements of another, equal sized range.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>875\</CodeContentPlaceHolder>  
 A forward iterator pointing to the first position of the first range whose elements are to be exchanged.  
  
 <CodeContentPlaceHolder>876\</CodeContentPlaceHolder>  
 A forward iterator pointing to one past the final position of the first range whose elements are to be exchanged.  
  
 <CodeContentPlaceHolder>877\</CodeContentPlaceHolder>  
 A forward iterator pointing to the first position of the second range whose elements are to be exchanged.  
  
### Return Value  
 A forward iterator pointing to one past the final position of the second range whose elements are to be exchanged.  
  
### Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation. The second range has to be as large as the first range.  
  
 The complexity is linear with <CodeContentPlaceHolder>878\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>879\</CodeContentPlaceHolder> swaps performed. If elements from containers of the same type are being swapped, them the <CodeContentPlaceHolder>880\</CodeContentPlaceHolder> member function from that container should be used, because the member function typically has constant complexity.  
  
### Example  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
  **Vector v1 is ( 0 1 2 3 4 5 ).**  
**Deque d1 is  ( 6 6 6 6 6 6 ).**  
**After the swap_range, vector v1 is ( 6 6 6 6 6 6 ).**  
**After the swap_range deque d1 is   ( 0 1 2 3 4 5 ).**    
##  \<a name="transform">\</a>  transform  
 Applies a specified function object to each element in a source range or to a pair of elements from two source ranges and copies the return values of the function object into a destination range.  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>881\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first source range to be operated on.  
  
 <CodeContentPlaceHolder>882\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first source range operated on.  
  
 <CodeContentPlaceHolder>883\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 <CodeContentPlaceHolder>884\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
 <CodeContentPlaceHolder>885\</CodeContentPlaceHolder>  
 User-defined unary function object used in the first version of the algorithm that is applied to each element in the first source range or A user-defined (UD) binary function object used in the second version of the algorithm that is applied pairwise, in a forward order, to the two source ranges.  
  
### Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
### Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation. The destination range must be large enough to contain the transformed source range.  
  
 If <CodeContentPlaceHolder>886\</CodeContentPlaceHolder> is set equal to <CodeContentPlaceHolder>887\</CodeContentPlaceHolder> in the first version of the algorithm *,* then the source and destination ranges will be the same and the sequence will be modified in place. But the <CodeContentPlaceHolder>888\</CodeContentPlaceHolder> may not address a position within the range [ <CodeContentPlaceHolder>889\</CodeContentPlaceHolder> +1, <CodeContentPlaceHolder>890\</CodeContentPlaceHolder>).  
  
 The complexity is linear with at most ( <CodeContentPlaceHolder>891\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>892\</CodeContentPlaceHolder>) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
  **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**The elements of the vector v1 multiplied by 2 in place gives:**  
 **v1mod = ( -8 -6 -4 -2 0 2 4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 & copying to v2 gives:**  
 **v2 = ( -40 -30 -20 -10 0 10 20 ).**  
**Multiplying elements of the vectors v1mod and v2 pairwise gives:**  
 **v3 = ( 320 180 80 20 0 20 80 ).**    
##  \<a name="unique">\</a>  unique  
 Removes duplicate elements that are adjacent to each other in a specified range.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>893\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be scanned for duplicate removal.  
  
 <CodeContentPlaceHolder>894\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be scanned for duplicate removal.  
  
 <CodeContentPlaceHolder>895\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator to the new end of the modified sequence that contains no consecutive duplicates, addressing the position one past the last element not removed.  
  
### Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation. he number of elements in the sequence is not changed by the algorithm **unique** and the elements beyond the end of the modified sequence are dereferenceable but not specified.  
  
 The complexity is linear, requiring ( <CodeContentPlaceHolder>896\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>897\</CodeContentPlaceHolder>) – 1 comparisons.  
  
 List provides a more efficient member function [unique](../vs140/list-class.md#list__unique), which may perform better.  
  
 These algorithms cannot be used on an associative container.  
  
### Example  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
  **Vector v1 is ( 5 -5 5 -5 5 -5 5 -5 4 4 4 4 7 ).**  
**Removing adjacent duplicates from vector v1 gives**  
 **( 5 -5 5 -5 5 -5 5 -5 4 7 ).**  
**Removing adjacent duplicates from vector v1 under the**  
 **binary predicate mod_equal gives**  
 **( 5 4 7 ).**  
**Removing adjacent elements satisfying the binary**  
 **predicate mod_equal from vector v1 gives ( 5 7 ).**    
##  \<a name="unique_copy">\</a>  unique_copy  
 Copies elements from a source range into a destination range except for the duplicate elements that are adjacent to each other.  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>898\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the source range to be copied.  
  
 <CodeContentPlaceHolder>899\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the source range to be copied.  
  
 <CodeContentPlaceHolder>900\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
 <CodeContentPlaceHolder>901\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
### Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within a sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear, requiring ( <CodeContentPlaceHolder>902\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>903\</CodeContentPlaceHolder>) comparisons.  
  
### Example  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
##  \<a name="upper_bound">\</a>  upper_bound  
 Finds the position of the first element in an ordered range that has a value that is greater than a specified value, where the ordering criterion may be specified by a binary predicate.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>904\</CodeContentPlaceHolder>  
 The position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>905\</CodeContentPlaceHolder>  
 The position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>906\</CodeContentPlaceHolder>  
 The value in the ordered range that needs to be exceeded by the value of the element addressed by the iterator returned.  
  
 <CodeContentPlaceHolder>907\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
### Return Value  
 A forward iterator to the position of the first element that has a value greater than a specified value.  
  
### Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of the use of <CodeContentPlaceHolder>908\</CodeContentPlaceHolder> and where the ordering criterion is the same as specified by the binary predicate.  
  
 The range is not modified by <CodeContentPlaceHolder>909\</CodeContentPlaceHolder>.  
  
 The value types of the forward iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to ( <CodeContentPlaceHolder>910\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
## See Also  
 [&lt;algorithm&gt;](../vs140/-algorithm-.md)