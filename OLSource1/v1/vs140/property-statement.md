---
title: "Property Statement"
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
  - "vb.PropertySet"
  - "vb.Property"
  - "vb.PropertyGet"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Property statement"
  - "default modifier"
  - "property procedures, Property statements"
  - "Property keyword"
ms.assetid: 3155edaf-8ebd-45c6-9cef-11d5d2dc8d38
caps.latest.revision: 45
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property Statement
Declares the name of a property, and the property procedures used to store and retrieve the value of the property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
     Optional. List of attributes that apply to this property or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     Optional. Specifies that this property is the default property for the class or structure on which it is defined. Default properties must accept parameters and can be set and retrieved without specifying the property name. If you declare the property as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you cannot use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the property or on either of its property procedures.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     Optional on the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement and on at most one of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statements. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Overloads](../vs140/overloads--visual-basic-.md)  
  
    -   [Overrides](../vs140/overrides--visual-basic-.md)  
  
    -   [Overridable](../vs140/overridable--visual-basic-.md)  
  
    -   [NotOverridable](../vs140/notoverridable--visual-basic-.md)  
  
    -   [MustOverride](../vs140/mustoverride--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
     Optional. See [Shared](../vs140/shared--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     Optional. See [ReadOnly](../vs140/readonly--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     Optional. See [WriteOnly](../vs140/writeonly--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
     Optional. See [Iterator](../vs140/iterator--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     Required. Name of the property. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
     Optional. List of local variable names representing the parameters of this property, and possible additional parameters of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> procedure. See [Parameter List](../vs140/parameter-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     Required if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Data type of the value returned by this property.  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
     Optional. Indicates that this property implements one or more properties, each one defined in an interface implemented by this property's containing class or structure. See [Implements Statement](../vs140/implements-statement.md).  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
     Required if <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is supplied. List of properties being implemented.  
  
     <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> has the following syntax and parts:  
  
     <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |Part|Description|  
    |<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Required. Name of an interface implemented by this property's containing class or structure.|  
    |<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Required. Name by which the property is defined in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
     Optional. Required if the property is marked <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. Starts a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> property procedure that is used to return the value of the property.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
     Optional. Block of statements to run within the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> procedure.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
     Terminates the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> property procedure.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
     Optional. Required if the property is marked <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. Starts a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> property procedure that is used to store the value of the property.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
     Terminates the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> property procedure.  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
     Terminates the definition of this property.  
  
## Remarks  
 The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement introduces the declaration of a property. A property can have a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> procedure (read only), a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> procedure (write only), or both (read-write). You can omit the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> procedure when using an auto-implemented property. For more information, see [Auto-Implemented Properties](../vs140/auto-implemented-properties--visual-basic-.md).  
  
 You can use <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> only at class level. This means the *declaration context* for a property must be a class, structure, module, or interface, and cannot be a source file, namespace, procedure, or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 By default, properties use public access. You can adjust a property's access level with an access modifier on the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> statement, and you can optionally adjust one of its property procedures to a more restrictive access level.  
  
 Visual Basic passes a parameter to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> procedure during property assignments. If you do not supply a parameter for <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, the integrated development environment (IDE) uses an implicit parameter named <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. This parameter holds the value to be assigned to the property. You typically store this value in a private local variable and return it whenever the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> procedure is called.  
  
## Rules  
  
-   **Mixed Access Levels.** If you are defining a read-write property, you can optionally specify a different access level for either the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> procedure, but not both. If you do this, the procedure access level must be more restrictive than the property's access level. For example, if the property is declared <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, you can declare the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, but not <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
     If you are defining a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> property, the single property procedure (<CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, respectively) represents all of the property. You cannot declare a different access level for such a procedure, because that would set two access levels for the property.  
  
-   **Return Type.** The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> statement can declare the data type of the value it returns. You can specify any data type or the name of an enumeration, structure, class, or interface.  
  
     If you do not specify <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, the property returns <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
-   **Implementation.** If this property uses the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> keyword, the containing class or structure must have an <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> statement immediately following its <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> statement must include each interface specified in <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. However, the name by which an interface defines the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> (in <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>) does not have to be the same as the name of this property (in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>).  
  
## Behavior  
  
-   **Returning from a Property Procedure.** When the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> procedure returns to the calling code, execution continues with the statement following the statement that invoked it.  
  
     The <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> statements cause an immediate exit from a property procedure. Any number of <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> statements can appear anywhere in the procedure, and you can mix <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> statements.  
  
-   **Return Value.** To return a value from a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> procedure, you can either assign the value to the property name or include it in a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> statement. The following example assigns the return value to the property name <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and then uses the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> statement to return.  
  
     [!code[VbVbalrStatements#27](../vs140/codesnippet/VisualBasic/property-statement_1.vb)]  
  
     [!code[VbVbalrStatements#28](../vs140/codesnippet/VisualBasic/property-statement_2.vb)]  
  
     If you use <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> without assigning a value to <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> procedure returns the default value for the property's data type.  
  
     The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> statement at the same time assigns the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> procedure return value and exits the procedure. The following example shows this.  
  
     [!code[VbVbalrStatements#27](../vs140/codesnippet/VisualBasic/property-statement_1.vb)]  
  
     [!code[VbVbalrStatements#29](../vs140/codesnippet/VisualBasic/property-statement_3.vb)]  
  
## Example  
 The following example declares a property in a class.  
  
 [!code[VbVbalrStatements#51](../vs140/codesnippet/VisualBasic/property-statement_4.vb)]  
  
## See Also  
 [Auto-Implemented Properties](../vs140/auto-implemented-properties--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Get Statement](../vs140/get-statement.md)   
 [Set Statement](../vs140/set-statement--visual-basic-.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)   
 [Default (Visual Basic)](../vs140/default--visual-basic-.md)