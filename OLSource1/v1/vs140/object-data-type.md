---
title: "Object Data Type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Object"
  - "vb.Variant"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "object variables, Object type"
  - "data types [Visual Basic], assigning"
  - "Object data type"
  - "Object data type, reference"
ms.assetid: 61ea4a7c-3b3d-48d4-adc4-eacfa91779b2
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object Data Type
Holds addresses that refer to objects. You can assign any reference type (string, array, class, or interface) to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variable. An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable can also refer to data of any value type (numeric, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, structure, or enumeration).  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> data type can point to data of any data type, including any object instance your application recognizes. Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when you do not know at compile time what data type the variable might point to.  
  
 The default value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (a null reference).  
  
## Data Types  
 You can assign a variable, constant, or expression of any data type to an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable. To determine the data type an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> variable currently refers to, you can use the \<xref:System.Type.GetTypeCode*> method of the \<xref:System.Type*?displayProperty=fullName> class. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data type is a reference type. However, Visual Basic treats an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> variable as a value type when it refers to data of a value type.  
  
## Storage  
 Whatever data type it refers to, an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable does not contain the data value itself, but rather a pointer to the value. It always uses four bytes in computer memory, but this does not include the storage for the data representing the value of the variable. Because of the code that uses the pointer to locate the data, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variables holding value types are slightly slower to access than explicitly typed variables.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, keep in mind that pointer types in other environments are not compatible with the Visual Basic <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> type.  
  
-   **Performance.** A variable you declare with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type is flexible enough to contain a reference to any object. However, when you invoke a method or property on such a variable, you always incur *late binding* (at run time). To force *early binding* (at compile time) and better performance, declare the variable with a specific class name, or cast it to the specific data type.  
  
     When you declare an object variable, try to use a specific class type, for example \<xref:System.OperatingSystem*>, instead of the generalized <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> type. You should also use the most specific class available, such as \<xref:System.Windows.Forms.TextBox*> instead of \<xref:System.Windows.Forms.Control*>, so that you can access its properties and methods. You can usually use the **Classes** list in the **Object Browser** to find available class names.  
  
-   **Widening.** All data types and all reference types widen to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> data type. This means you can convert any type to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> without encountering a \<xref:System.OverflowException*?displayProperty=fullName> error.  
  
     However, if you convert between value types and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, Visual Basic performs operations called *boxing* and *unboxing*, which make execution slower.  
  
-   **Type Characters.** <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> has no literal type character or identifier type character.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.Object*?displayProperty=fullName> class.  
  
## Example  
 The following example illustrates an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> variable pointing to an object instance.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Object*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Related](../vs140/how-to--determine-whether-two-objects-are-related--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Identical](../vs140/how-to--determine-whether-two-objects-are-identical--visual-basic-.md)