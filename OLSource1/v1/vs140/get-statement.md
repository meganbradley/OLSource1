---
title: "Get Statement"
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
  - "vb.Get"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Get statement, syntax"
  - "Get statement"
  - "properties [Visual Basic], read-only"
  - "read-only properties"
  - "Get keyword"
  - "property procedures, Get statements"
ms.assetid: 56b05cdc-bd64-4dfd-bb12-824eacec6f94
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Get Statement
Declares a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property procedure used to retrieve the value of a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional on at most one of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statements in this property. Can be one of the following:\<br />\<br /> -   [Protected](../vs140/protected--visual-basic-.md)\<br />-   [Friend](../vs140/friend--visual-basic-.md)\<br />-   [Private](../vs140/private--visual-basic-.md)\<br />-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>\<br />\<br /> See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. One or more statements that run when the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property procedure is called.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> property procedure.|  
  
## Remarks  
 Every property must have a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property procedure unless the property is marked <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> procedure is used to return the current value of the property.  
  
 Visual Basic automatically calls a property's <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> procedure when an expression requests the property's value.  
  
 The body of the property declaration can contain only the property's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> procedures between the [Property Statement](../vs140/property-statement.md) and the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement. It cannot store anything other than those procedures. In particular, it cannot store the property's current value. You must store this value outside the property, because if you store it inside either of the property procedures, the other property procedure cannot access it. The usual approach is to store the value in a [Private (Visual Basic)](../vs140/private--visual-basic-.md) variable declared at the same level as the property. You must define a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> procedure inside the property to which it applies.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure defaults to the access level of its containing property unless you use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement.  
  
## Rules  
  
-   **Mixed Access Levels.** If you are defining a read-write property, you can optionally specify a different access level for either the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure, but not both. If you do this, the procedure access level must be more restrictive than the property's access level. For example, if the property is declared <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, you can declare the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, but not <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
     If you are defining a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> property, the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> procedure represents the entire property. You cannot declare a different access level for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, because that would set two access levels for the property.  
  
-   **Return Type.** The [Property Statement](../vs140/property-statement.md) can declare the data type of the value it returns. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> procedure automatically returns that data type. You can specify any data type or the name of an enumeration, structure, class, or interface.  
  
     If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement does not specify <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the procedure returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
## Behavior  
  
-   **Returning from a Procedure.** When the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> procedure returns to the calling code, execution continues within the statement that requested the property value.  
  
     <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> property procedures can return a value using either the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) or by assigning the return value to the property name. For more information, see "Return Value" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
     The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statements cause an immediate exit from a property procedure. Any number of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statements can appear anywhere in the procedure, and you can mix <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> statements.  
  
-   **Return Value.** To return a value from a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> procedure, you can either assign the value to the property name or include it in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md). The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement simultaneously assigns the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> procedure return value and exits the procedure.  
  
     If you use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> without assigning a value to the property name, the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> procedure returns the default value for the property's data type. For more information, see "Return Value" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
     The following example illustrates two ways the read-only property <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> can return the value held in the private variable <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrStatements#27](../vs140/codesnippet/VisualBasic/get-statement_1.vb)]  
  
     [!code[VbVbalrStatements#28](../vs140/codesnippet/VisualBasic/get-statement_2.vb)]  
  
     [!code[VbVbalrStatements#29](../vs140/codesnippet/VisualBasic/get-statement_3.vb)]  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement to return the value of a property.  
  
 [!code[VbVbalrStatements#30](../vs140/codesnippet/VisualBasic/get-statement_4.vb)]  
  
## See Also  
 [Set Statement](../vs140/set-statement--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Walkthrough: Defining Classes](../vs140/walkthrough--defining-classes--visual-basic-.md)