---
title: "SafeInt::SafeInt"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "SafeInt::SafeInt"
  - "SafeInt"
  - "SafeInt.SafeInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeInt class, constructor"
ms.assetid: 39e6f632-a396-40e6-9ece-cc3d4c5a78ef
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeInt::SafeInt
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value for the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. This must be a parameter of type T or U, depending on the constructor.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The Boolean value for the new <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of type U. The new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object will have the same value as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, but will be of type T.  
  
 U  
 The type of data stored in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This can be either a Boolean, character, or integer type. If it is an integer type, it can be signed or unsigned and be between 8 and 64 bits.  
  
## Remarks  
 For more information about the template types <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, see [SafeInt Class](../vs140/safeint-class.md).  
  
 The input parameter for the constructor, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, must be a Boolean, character, or integer type. If it is another type of parameter, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class calls [static_assert](../vs140/static_assert.md) to indicate an invalid input parameter.  
  
 The constructors that use the template type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> automatically convert the input parameter to the type specified by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class converts the data without any loss of data. It reports to the error handler <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if it cannot convert the data to type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> without data loss.  
  
 If you create a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> from a Boolean parameter, you need to initialize the value immediately. You cannot construct a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> using the code <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. This will generate a compile error.  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** msl::utilities  
  
## See Also  
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeInt Class](../vs140/safeint-class.md)   
 [SafeIntException Class](../vs140/safeintexception-class.md)