---
title: "Properties of Domain Roles"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5a7bb18c-638e-45e8-9d79-9aa6a9e14b0e
caps.latest.revision: 13
---
# Properties of Domain Roles
The properties in the following table are associated with a domain role. For information about domain roles, see [Understanding Models, Classes, and Relationships](../vs140/understanding-models--classes-and-relationships.md). For more information about how to use these properties, see [Customizing and Extending a Domain Specific Language](../vs140/customizing-and-extending-a-domain-specific-language.md).  
  
|Property|Description|Default|  
|--------------|-----------------|-------------|  
|Collection Type|If this role has multiplicity of 0..* or 1..\*, this property customizes the generic type that is used to store the collection of links.|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> - <xref:Microsoft.VisualStudio.Modeling.LinkedElementCollection<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>public<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>internal<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>private<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>protected<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>protected internal<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>public<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>public<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>internal<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>private<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>protected<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>protected internal<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>public<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>0..1<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>1..1<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>0..*<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>1..*<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>0..*<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>1..*<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>DoNotPropagateCopy<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>PropagateCopyToLinkOnly<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>PropagateCopyToLinkAndOppositeRolePlayer<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>PropagateCopyToLinkAndOppositeRolePlayer<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>DoNotPropagateCopy<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>Description for` *the full name of the role*|  
|Display Name|The name that is displayed in the generated designer for the domain role.|The adjusted value of the Name property.|  
|Help Keyword|The optional keyword that is used to index F1 help for the domain role.|\<none>|  
|Property Display Name|The name that is displayed in the generated designer for the generated role property.|The adjusted value of the Property Name property.|  
  
> [!NOTE]
>  The default value of a display name is based on the associated property value by inserting spaces before each upper-case character that is preceded by a lower-case character and that is not followed by another upper-case character.  
  
## See Also  
 [Properties of Domain Relationships](../vs140/properties-of-domain-relationships.md)