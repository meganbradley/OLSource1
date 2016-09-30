---
title: "Annotating Structs and Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_Field_size_bytes_part_"
  - "_Field_size_bytes_full_opt_"
  - "_Field_size_bytes_"
  - "_Field_size_opt_"
  - "_Field_size_part_"
  - "_Field_size_bytes_part_opt_"
  - "_Field_range_"
  - "_Field_size_part_opt_"
  - "_Field_size_"
  - "_Field_size_bytes_opt_"
  - "_Struct_size_bytes_"
  - "_Field_size_bytes_full_"
  - "_Field_size_full_"
  - "_Field_size_full_opt_"
ms.assetid: b8278a4a-c86e-4845-aa2a-70da21a1dd52
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Annotating Structs and Classes
You can annotate struct and class members by using annotations that act like invariants—they are presumed to be true at any function call or function entry/exit that involves the enclosing structure as a parameter or a result value.  
  
## Struct and Class Annotations  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     The field is in the range (inclusive) from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  Equivalent to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> applied to the annotated object by using the appropriate pre or post conditions.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
     A field that has a writable size in elements (or bytes) as specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>,         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     A field that has a writable size in elements (or bytes) as specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> of those elements (bytes) that are readable.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     A field that has both readable and writable size in elements (or bytes) as specified by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
     A field that has both readable and writable size in elements (or bytes) as specified by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
     Applies to struct or class declaration.  Indicates that a valid object of that type may be larger than the declared type, with the number of bytes being specified by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The buffer size in bytes of a parameter <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is then taken to be:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)