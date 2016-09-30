---
title: "Vectorizer and Parallelizer Messages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C5011"
  - "C5002"
  - "C5021"
  - "C5001"
  - "C5012"
dev_langs: 
  - "C++"
ms.assetid: d8f4844a-f414-42ab-b9a5-925a5da9d365
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Vectorizer and Parallelizer Messages
You can use the Visual C++ compiler options [/Qpar-report](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md) and [/Qvec-report](../vs140/-qvec-report--auto-vectorizer-reporting-level-.md) to set the [Auto-Parallelizer and Auto-Vectorizer](../vs140/auto-parallelization-and-auto-vectorization.md) to output reason codes and informational messages about its activity. This article explains the reason codes and the messages.  
  
-   [Informational Messages 5001 through 5021](#BKMK_InformationalMessages)  
  
-   [5xx](#BKMK_ReasonCode50x)  
  
-   [Reason Code 1000 through 1010](#BKMK_ReasonCode100x)  
  
-   [Reason Code 1100 through 1106](#BKMK_ReasonCode110x)  
  
-   [Reason Code 1200 through 1203](#BKMK_ReasonCode120x)  
  
-   [Reason Code 1300 through 1305](#BKMK_ReasonCode130x)  
  
-   [Reason Code 1400 through 1405](#BKMK_ReasonCode140x)  
  
-   [Reason Code 1500 through 1505](#BKMK_ReasonCode150x)  
  
##  \<a name="BKMK_InformationalMessages">\</a> Informational Messages  
 Depending on the reporting level that you specify, one of the following informational messages appears for each loop.  
  
 For information about reason codes, refer to the next part of this article.  
  
|Informational Message|Description|  
|---------------------------|-----------------|  
|5001|Loop vectorized.|  
|5002|Loop not vectorized due to reason 'description'.|  
|5011|Loop parallelized.|  
|5012|Loop not parallelized due to reason 'description'.|  
|5021|Unable to associate loop with pragma.|  
  
## Reason Codes  
 The following sections list possible reason codes for the auto-parallelizer and auto-vectorizer.  
  
###  \<a name="BKMK_ReasonCode50x">\</a> 5xx  
 The 5*xx* reason codes apply to both the auto-parallelizer and the auto-vectorizer.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|500|This is a generic message that covers several cases—for example, the loop includes multiple exits, or the loop header does not end by incrementing the induction variable.|  
|501|Induction variable is not local; or upper bound is not loop-invariant.|  
|502|Induction variable is stepped in some manner other than a simple +1.|  
|503|Loop includes exception-handling or switch statements.|  
|504|Loop body may throw an exception that requires destruction of a C++ object.|  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode100x">\</a> 10xx  
 The 10*xx* reason codes apply to the auto-parallelizer.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1000|The compiler detected a data dependency in the loop body.|  
|1001|The compiler detected a store to a scalar variable in the loop body, and that scalar has a use beyond the loop.|  
|1002|The compiler tried to parallelize a loop that has an inner loop that was already parallelized.|  
|1003|The loop body contains an intrinsic call that may read or write to memory.|  
|1004|There is a scalar reduction in the loop body. Scalar reduction can occur if the loop has been vectorized.|  
|1005|The **no_parallel** pragma was specified.|  
|1006|This function contains **openmp**. Resolve this by removing any **openmp** in this function.|  
|1007|The loop induction variable or the loop bounds are not signed 32-bit numbers (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). Resolve this by changing the type of the induction variable.|  
|1008|The compiler detected that this loop does not perform enough work to warrant auto-parallelization.|  
|1009|The compiler detected an attempt to parallelize a "do-while" loop. The auto-parallelizer only targets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loops.|  
|1010|The compiler detected that the loop is using "not-equals" (!=) for its condition.|  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode110x">\</a> 11xx  
 The 11*xx* reason codes apply to the auto-vectorizer.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1100|Loop contains control flow—for example, "if" or "?".|  
|1101|Loop contains datatype conversion—perhaps implicit—that cannot be vectorized.|  
|1102|Loop contains non-arithmetic or other non-vectorizable operations.|  
|1103|Loop body includes shift operations whose size might vary within the loop.|  
|1104|Loop body includes scalar variables.|  
|1105|Loop includes a unrecognized reduction operation.|  
|1106|Outer loop not vectorized.|  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode120x">\</a> 12xx  
 The 12*xx* reason codes apply to the auto-vectorizer.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1200|Loop contains loop-carried data dependences that prevent vectorization. Different iterations of the loop interfere with each other such that vectorizing the loop would produce wrong answers, and the auto-vectorizer cannot prove to itself that there are no such data dependences.|  
|1201|Array base changes during the loop.|  
|1202|Field in a struct is not 32 or 64 bits wide.|  
|1203|Loop body includes non-contiguous accesses into an array.|  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode130x">\</a> 13xx  
 The 13*xx* reason codes apply to the auto-vectorizer.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1300|Loop body contains no—or very little—computation.|  
|1301|Loop stride is not +1.|  
|1302|Loop is a “do-while”.|  
|1303|Too few loop iterations for vectorization to provide value.|  
|1304|Loop includes assignments that are of different sizes.|  
|1305|Not enough type information.|  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode140x">\</a> 14xx  
 The 14*xx* reason codes occur when some option that is incompatible with auto-vectorization is specified.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1400|**#pragma loop(no_vector)** is specified.|  
|1401|**/kernel** switch is specified when targeting x86 or ARM.|  
|1402|**/arch:SSE2** or higher switch is not specified when targeting x86.|  
|1403|**/arch:ATOM** switch is specified and the loop includes operations on doubles.|  
|1404|**/O1** or **/Os** switch is specified.|  
|1405|Vectorization is disabled to aid in dynamic-initializer-to-static-initializer optimization.|  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
###  \<a name="BKMK_ReasonCode150x">\</a> 15xx  
 The block of 15*xx* reason codes apply to aliasing. Aliasing occurs when a location in memory can be accessed by two different names.  
  
|Reason Code|Explanation|  
|-----------------|-----------------|  
|1500|Possible aliasing on multi-dimensional arrays.|  
|1501|Possible aliasing on arrays-of-structs.|  
|1502|Possible aliasing and array index is other than n + K.|  
|1503|Possible aliasing and array index has multiple offsets.|  
|1504|Possible aliasing; would require too many runtime checks.|  
|1505|Possible aliasing, but runtime checks are too complex.|  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Auto-Parallelizer and Auto-Vectorizer](../vs140/auto-parallelization-and-auto-vectorization.md)   
 [Parallel Programming in Native Code](http://go.microsoft.com/fwlink/?LinkId=263662)   
 [#pragma loop()](../vs140/loop.md)   
 [/Q Options (Low-Level Operations)](../vs140/-q-options--low-level-operations-.md)   
 [/Qpar-report](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md)   
 [/Qvec-report](../vs140/-qvec-report--auto-vectorizer-reporting-level-.md)