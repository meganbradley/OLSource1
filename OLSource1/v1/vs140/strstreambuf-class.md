---
title: "strstreambuf Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.strstreambuf"
  - "strstreambuf"
  - "std::strstreambuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstreambuf class"
ms.assetid: b040b8ea-0669-4eba-8908-6a9cc159c54b
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf Class
Describes a stream buffer that controls the transmission of elements to and from a sequence of elements stored in a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Depending on how the object is constructed, it can be allocated, extended, and freed as necessary to accommodate changes in the sequence.  
  
 An object of class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> stores several bits of mode information as its <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> mode. These bits indicate whether the controlled sequence:  
  
-   Has been allocated and needs to be freed eventually.  
  
-   Is modifiable.  
  
-   Is extendable by reallocating storage.  
  
-   Has been frozen and hence needs to be unfrozen before the object is destroyed, or freed (if allocated) by an agency other than the object.  
  
 A controlled sequence that is frozen cannot be modified or extended, regardless of the state of these separate mode bits.  
  
 The object also stores pointers to two functions that control <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> allocation. If these are null pointers, the object devises its own method of allocating and freeing storage for the controlled sequence.  
  
> [!NOTE]
>  This class is deprecated. Consider using [stringbuf](../vs140/-sstream--typedefs.md#stringbuf) or [wstringbuf](../vs140/-sstream--typedefs.md#wstringbuf) instead.  
  
### Constructors  
  
|||  
|-|-|  
|[strstreambuf](#strstreambuf__strstreambuf)|Constructs an object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[freeze](#strstreambuf__freeze)|Causes a stream buffer to be unavailable through stream buffer operations.|  
|[overflow](#strstreambuf__overflow)|A protected virtual function that can be called when a new character is inserted into a full buffer.|  
|[pbackfail](#strstreambuf__pbackfail)|A protected virtual member function that tries to put back an element into the input stream, and then make it the current element (pointed to by the next pointer).|  
|[pcount](#strstreambuf__pcount)|Returns a count of the number of elements written to the controlled sequence.|  
|[seekoff](#strstreambuf__seekoff)|A protected virtual member function that tries to alter the current positions for the controlled streams.|  
|[seekpos](#strstreambuf__seekpos)|A protected virtual member function that tries to alter the current positions for the controlled streams.|  
|[str](#strstreambuf__str)|Calls [freeze](#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.|  
|[underflow](#strstreambuf__underflow)|A protected virtual function to extract the current element from the input stream.|  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
##  \<a name="strstreambuf__freeze">\</a>  strstreambuf::freeze  
 Causes a stream buffer to be unavailable through stream buffer operations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> indicating whether you want the stream to be frozen.  
  
### Remarks  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is true, the function alters the stored <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> mode to make the controlled sequence frozen. Otherwise, it makes the controlled sequence not frozen.  
  
 [str](#strstreambuf__str) implies <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  A frozen buffer will not be freed during <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> destruction. You must unfreeze the buffer before it is freed to avoid a memory leak.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **before freeze: stream good**  
**test1**  
**after freeze: stream good**  
**after write to frozen stream: stream bad**  
**after unfreezing stream: stream bad**  
**after clearing stream: stream good**  
**test1test3**    
##  \<a name="strstreambuf__overflow">\</a>  strstreambuf::overflow  
 A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Return Value  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Otherwise, if _                        *Meta* == <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, it returns some value other than <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. Otherwise, it returns \_                        *Meta*.  
  
### Remarks  
 If _                        *Meta* != <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the protected virtual member function tries to insert the element ( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>)\_                        *Meta* into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   If the stored strstreambuf mode says the controlled sequence is modifiable, extendable, and not frozen, the function can make a write position available by allocating new for the output buffer. Extending the output buffer this way also extends any associated input buffer.  
  
##  \<a name="strstreambuf__pbackfail">\</a>  strstreambuf::pbackfail  
 A protected virtual member function that tries to put back an element into the input stream, and then makes it the current element (pointed to by the next pointer).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Return Value  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Otherwise, if _                        *Meta* == <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, it returns some value other than <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. Otherwise, it returns \_                        *Meta*.  
  
### Remarks  
 The protected virtual member function tries to put back an element into the input buffer, and then make it the current element (pointed to by the next pointer).  
  
 If _                        *Meta* == <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **ch** = ( <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>)\_                        *Meta*. The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to **ch**, it can decrement the next pointer for the input buffer.  
  
-   If a putback position is available, and if the strstreambuf mode says the controlled sequence is modifiable, the function can store **ch** into the putback position and decrement the next pointer for the input buffer.  
  
##  \<a name="strstreambuf__pcount">\</a>  strstreambuf::pcount  
 Returns a count of the number of elements written to the controlled sequence.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A count of the number of elements written to the controlled sequence.  
  
### Remarks  
 Specifically, if [pptr](../vs140/basic_streambuf-class.md#basic_streambuf__pptr) is a null pointer, the function returns zero. Otherwise, it returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> – [pbase](../vs140/basic_streambuf-class.md#basic_streambuf__pbase).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="strstreambuf__seekoff">\</a>  strstreambuf::seekoff  
 A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base-class.md#ios_base__seekdir) for possible values.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 If the function succeeds in altering either or both stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position.  
  
### Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class strstreambuf, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence.  
  
 The new position is determined as follows:  
  
-   If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the new position is the beginning of the stream plus _                                *Off*.  
  
-   If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, the new position is the current stream position plus _                                *Off*.  
  
-   If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, the new position is the end of the stream plus _                                *Off*.  
  
 If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> &  **ios_base::in** is nonzero and the input buffer exist, the function alters the next position to read in the input buffer. If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> &  **ios_base::out** is also nonzero, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> !=  **ios_base::cur**, and the output buffer exists, the function also sets the next position to write to match the next position to read.  
  
 Otherwise, if <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> & <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is nonzero and the output buffer exists, the function alters the next position to write in the output buffer. Otherwise, the positioning operation fails. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence.  
  
##  \<a name="strstreambuf__seekpos">\</a>  strstreambuf::seekpos  
 A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
### Return Value  
 If the function succeeds in altering either or both stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class strstreambuf, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence. The new position is determined by _                        *Sp*.  
  
 If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> & **ios_base::in** is nonzero and the input buffer exists, the function alters the next position to read in the input buffer. If <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> & <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is nonzero and the output buffer exists, the function also sets the next position to write to match the next position to read. Otherwise, if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> & <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is nonzero and the output buffer exists, the function alters the next position to write in the output buffer. Otherwise, the positioning operation fails. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence.  
  
##  \<a name="strstreambuf__str">\</a>  strstreambuf::str  
 Calls [freeze](#strstreambuf__freeze), and then returns a pointer to the beginning of the controlled sequence.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the beginning of the controlled sequence.  
  
### Remarks  
 No terminating null element exists, unless you explicitly insert one.  
  
### Example  
  See [strstreambuf::freeze](#strstreambuf__freeze) for a sample that uses **str**.  
  
##  \<a name="strstreambuf__strstreambuf">\</a>  strstreambuf::strstreambuf  
 Constructs an object of type <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *_Allocfunc*  
 The function used to allocate buffer memory.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Determines the length of the buffer pointed to by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is not an argument (first constructor form), a suggested allocation size for the buffers.  
  
 *_Freefunc*  
 The function used to free buffer memory.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A buffer used for input.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A buffer used for output.  
  
### Remarks  
 The first constructor stores a null pointer in all the pointers controlling the input buffer, the output buffer, and strstreambuf allocation. It sets the stored strstreambuf mode to make the controlled sequence modifiable and extendable. It also accepts <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> as a suggested initial allocation size.  
  
 The second constructor behaves like the first, except that it stores _                        *Allocfunc* as the pointer to the function to call to allocate storage and \_                        *Freefunc* as the pointer to the function to call to free that storage.  
  
 The three constructors:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 also behave like the first, except that <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> designates the array object used to hold the controlled sequence. (Hence, it must not be a null pointer.) The number of elements                         *N* in the array is determined as follows:  
  
-   If ( <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> > 0), then                                 *N* is **count**.  
  
-   If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> == 0), then                                 *N* is <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>( ( **const**<CodeContentPlaceHolder>77\</CodeContentPlaceHolder> *) <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> ).  
  
-   If ( <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> < 0), then                                 *N* is **INT_MAX**.  
  
 If <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is a null pointer, the function establishes just an input buffer by executing:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Otherwise, it establishes both input and output buffers by executing:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 In this case, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> must be in the interval [ <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> +                         *N*].  
  
 Finally, the three constructors:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 all behave the same as:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 except that the stored mode makes the controlled sequence neither modifiable nor extendable.  
  
##  \<a name="strstreambuf__underflow">\</a>  strstreambuf::underflow  
 A protected virtual function to extract the current element from the input stream.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. Otherwise, it returns the current element in the input stream, converted as described above.  
  
### Remarks  
 The protected virtual member function endeavors to extract the current element **ch** from the input buffer, then advance the current stream position, and return the element as ( <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>)( <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>) **ch**. It can do so in only one way: if a read position is available, it takes **ch** as the element stored in the read position and advances the next pointer for the input buffer.  
  
## See Also  
 [streambuf](../vs140/-streambuf--typedefs.md#streambuf)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)