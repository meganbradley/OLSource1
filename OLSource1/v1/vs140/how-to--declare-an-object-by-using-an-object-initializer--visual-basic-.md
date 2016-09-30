---
title: "How to: Declare an Object by Using an Object Initializer (Visual Basic)"
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
  - "declaring objects using object initializer"
  - "object initializers [Visual Basic]"
  - "initializers [Visual Basic]"
  - "Video How tos, Visual Basic"
ms.assetid: 0f53a553-efd6-466d-80bf-6b679e5cd174
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare an Object by Using an Object Initializer (Visual Basic)
Object initializers enable you to declare and instantiate an instance of a class in a single statement. In addition, you can initialize one or more members of the instance at the same time, without invoking a parameterized constructor.  
  
 When you use an object initializer to create an instance of a named type, the default constructor for the class is called, followed by initialization of designated members in the order you specify.  
  
 The following procedure shows how to create an instance of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class in three different ways. The class has first name, last name, and class year properties, among others. Each of the three declarations creates a new instance of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, with property <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> set to "Michael", property <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> set to "Tucker", and all other members set to their default values. The result of each declaration in the procedure is equivalent to the following example, which does not use an object initializer.  
  
 [!code[VbVbalrObjectInit#20](../vs140/codesnippet/VisualBasic/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-_1.vb)]  
  
 For an implementation of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class, see [How to: Create a List of Items](../vs140/how-to--create-a-list-of-items.md). You can copy the code from that topic to set up the class and create a list of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects to work with.  
  
### To create an object of a named class by using an object initializer  
  
1.  Begin the declaration as if you planned to use a constructor.  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
2.  Type the keyword <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, followed by an initialization list in braces.  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
3.  In the initialization list, include each property that you want to initialize and assign an initial value to it. The name of the property is preceded by a period.  
  
     [!code[VbVbalrObjectInit#21](../vs140/codesnippet/VisualBasic/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-_2.vb)]  
  
     You can initialize one or more members of the class.  
  
4.  Alternatively, you can declare a new instance of the class and then assign a value to it. First, declare an instance of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>:  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
5.  Begin the creation of an instance of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the normal way.  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
6.  Type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and then an object initializer to initialize one or more members of the new instance.  
  
     [!code[VbVbalrObjectInit#22](../vs140/codesnippet/VisualBasic/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-_3.vb)]  
  
7.  You can simplify the definition in the previous step by omitting <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If you do this, the compiler determines that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is an instance of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> by using local type inference.  
  
     [!code[VbVbalrObjectInit#23](../vs140/codesnippet/VisualBasic/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-_4.vb)]  
  
     For more information, see [Local Type Inference](../vs140/local-type-inference--visual-basic-.md).  
  
## See Also  
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [How to: Create a List of Items](../vs140/how-to--create-a-list-of-items.md)   
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Anonymous Types (Visual Basic)](../vs140/anonymous-types--visual-basic-.md)