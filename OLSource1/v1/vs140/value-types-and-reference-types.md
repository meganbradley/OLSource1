---
title: "Value Types and Reference Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "reference data types"
  - "reference types"
  - "value types"
  - "value data types"
  - "types [Visual Basic]"
  - "data types [Visual Basic], value types"
  - "data types [Visual Basic], reference types"
ms.assetid: fc82ce15-5a40-4c5c-a1e1-a556830e7391
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value Types and Reference Types
In Visual Basic, data types are implemented based on their classification. The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types can be classified according to whether a variable of a particular type stores its own data or a pointer to the data. If it stores its own data it is a *value type*; if it holds a pointer to data elsewhere in memory it is a *reference type*.  
  
## Value Types  
 A data type is a *value type* if it holds the data within its own memory allocation. Value types include the following:  
  
-   All numeric data types  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   All structures, even if their members are reference types  
  
-   Enumerations, since their underlying type is always <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 Every structure is a value type, even if it contains reference type members. For this reason, value types such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are implemented by .NET Framework structures.  
  
 You can declare a value type by using the reserved keyword, for example, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. You can also use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword to initialize a value type. This is especially useful if the type has a constructor that takes parameters. An example of this is the \<xref:System.Decimal.#ctor(System.Int32,System.Int32,System.Int32,System.Boolean,System.Byte)> constructor, which builds a new <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value from the supplied parts.  
  
## Reference Types  
 A *reference type* contains a pointer to another memory location that holds the data. Reference types include the following:  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
-   All arrays, even if their elements are value types  
  
-   Class types, such as \<xref:System.Windows.Forms.Form*>  
  
-   Delegates  
  
 A class is a *reference type*. For this reason, reference types such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are supported by [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] classes. Note that every array is a reference type, even if its members are value types.  
  
 Since every reference type represents an underlying .NET Framework class, you must use the [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) keyword when you initialize it. The following statement initializes an array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements That Are Not Types  
 The following programming elements do not qualify as types, because you cannot specify any of them as a data type for a declared element:  
  
-   Namespaces  
  
-   Modules  
  
-   Events  
  
-   Properties and procedures  
  
-   Variables, constants, and fields  
  
## Working with the Object Data Type  
 You can assign either a reference type or a value type to a variable of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> data type. An <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> variable always holds a pointer to the data, never the data itself. However, if you assign a value type to an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> variable, it behaves as if it holds its own data. For more information, see [Object Data Type](../vs140/object-data-type.md).  
  
 You can find out whether an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> variable is acting as a reference type or a value type by passing it to the \<xref:Microsoft.VisualBasic.Information.IsReference*> method in the \<xref:Microsoft.VisualBasic.Information*> class of the \<xref:Microsoft.VisualBasic*?displayProperty=fullName> namespace. \<xref:Microsoft.VisualBasic.Information.IsReference*?displayProperty=fullName> returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the content of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> variable represents a reference type.  
  
## See Also  
 [Nullable Value Types (Visual Basic)](../vs140/nullable-value-types--visual-basic-.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)