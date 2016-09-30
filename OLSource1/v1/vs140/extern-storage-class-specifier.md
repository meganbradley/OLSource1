---
title: "extern Storage-Class Specifier"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "extern keyword [C]"
  - "storage class specifiers, extern"
  - "extern keyword [C], storage class specifier"
  - "external linkage, storage-class specifiers"
  - "external linkage, extern modifier"
ms.assetid: 6e16d927-291f-49e4-986c-9d91a482a441
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extern Storage-Class Specifier
A variable declared with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> storage-class specifier is a reference to a variable with the same name defined at the external level in any of the source files of the program. The internal <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> declaration is used to make the external-level variable definition visible within the block. Unless otherwise declared at the external level, a variable declared with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword is visible only in the block in which it is declared.  
  
## Example  
 This example illustrates internal- and external-level declarations:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is defined at the external level with initial value 1. An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> declaration in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is used to declare a reference to the external-level <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The **static** variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is initialized to 0 by default, since the initializer is omitted. The call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> prints the values 1, 0, 0, and 0.  
  
 In the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function, the address of the global variable <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is used to initialize the **static** pointer variable <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This works because the global variable has **static** lifetime, meaning its address does not change during program execution. Next, the variable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is redefined as a local variable with initial value 16. This redefinition does not affect the value of the external-level <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which is hidden by the use of its name for the local variable. The value of the global <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is now accessible only indirectly within this block, through the pointer <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Attempting to assign the address of the **auto** variable <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a pointer does not work, since it may be different each time the block is entered. The variable <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is declared as a **static** variable and initialized to 2. This <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not conflict with the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, since **static** variables at the internal level are visible only within the block in which they are declared.  
  
 The variable <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is increased by 2, giving 4 as the result. If the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function were called again in the same program, the initial value of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> would be 4. Internal **static** variables keep their values when the program exits and then reenters the block in which they are declared.  
  
## See Also  
 [Storage-Class Specifiers for Internal-Level Declarations](../vs140/storage-class-specifiers-for-internal-level-declarations.md)