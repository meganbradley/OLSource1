---
title: "Set Statement (Visual Basic)"
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
  - "vb.Set"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "property procedures, Set statements"
  - "Set statement"
  - "Set statement, syntax"
  - "write-only properties"
  - "properties [Visual Basic], write-only"
ms.assetid: 9ecc27b4-df84-420d-9075-db25455fb3cd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set Statement (Visual Basic)
Declares a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property procedure used to assign a value to a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional on at most one of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statements in this property. Can be one of the following:  
  
-   [Protected](../vs140/protected--visual-basic-.md)  
  
-   [Friend](../vs140/friend--visual-basic-.md)  
  
-   [Private](../vs140/private--visual-basic-.md)  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. Parameter containing the new value for the property.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Data type of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. The data type specified must be the same as the data type of the property where this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement is declared.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Optional. One or more statements that run when the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property procedure is called.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Required. Terminates the definition of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> property procedure.  
  
## Remarks  
 Every property must have a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> property procedure unless the property is marked <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure is used to set the value of the property.  
  
 Visual Basic automatically calls a property's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> procedure when an assignment statement provides a value to be stored in the property.  
  
 Visual Basic passes a parameter to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedure during property assignments. If you do not supply a parameter for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the integrated development environment (IDE) uses an implicit parameter named <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The parameter holds the value to be assigned to the property. You typically store this value in a private local variable and return it whenever the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> procedure is called.  
  
 The body of the property declaration can contain only the property's <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedures between the [Property Statement](../vs140/property-statement.md) and the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement. It cannot store anything other than those procedures. In particular, it cannot store the property's current value. You must store this value outside the property, because if you store it inside either of the property procedures, the other property procedure cannot access it. The usual approach is to store the value in a [Private (Visual Basic)](../vs140/private--visual-basic-.md) variable declared at the same level as the property. You must define a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> procedure inside the property to which it applies.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> procedure defaults to the access level of its containing property unless you use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement.  
  
## Rules  
  
-   **Mixed Access Levels.** If you are defining a read-write property, you can optionally specify a different access level for either the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> procedure, but not both. If you do this, the procedure access level must be more restrictive than the property's access level. For example, if the property is declared <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, you can declare the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, but not <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
     If you are defining a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> property, the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> procedure represents the entire property. You cannot declare a different access level for <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, because that would set two access levels for the property.  
  
## Behavior  
  
-   **Returning from a Property Procedure.** When the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> procedure returns to the calling code, execution continues following the statement that provided the value to be stored.  
  
     <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> property procedures can return using either the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) or the [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md).  
  
     The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statements cause an immediate exit from a property procedure. Any number of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statements can appear anywhere in the procedure, and you can mix <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> statements.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement to set the value of a property.  
  
 [!code[VbVbalrStatements#55](../vs140/codesnippet/VisualBasic/set-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Get Statement](../vs140/get-statement.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)