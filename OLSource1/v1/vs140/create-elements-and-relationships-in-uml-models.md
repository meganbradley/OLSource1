---
title: "Create elements and relationships in UML models"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API"
ms.assetid: cae81d32-8cc7-4f7c-9f00-20119952bc51
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Create elements and relationships in UML models
In the program code for an extension to Visual Studio, you can create and delete elements and relationships.  
  
## Create a Model Element  
  
### Namespace Imports  
 You must include the following <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statements.  
  
 The creation methods are defined as extension methods in this namespace:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
### Obtain the owner of the element you want to create  
 A model forms a single tree, so that every item has one owner, except for the model root. The model root is of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is a type of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 If you are creating an element that will be displayed in a particular diagram, for example, the user's current diagram, you should usually create it in the package that is linked to that diagram. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This table summarizes the ownership of common model elements:  
  
|Element to be Created|Owner|  
|---------------------------|-----------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
### Invoke the Create method on the owner  
 The method name is of the form: <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>*OwnedType*<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Some types have more complex creation methods, particularly in Sequence Diagrams. See [How to Edit Interactions using the API](../vs140/edit-uml-sequence-diagrams-by-using-the-uml-api.md).  
  
 For some types of element, you can change the owner of an element during its lifetime, using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Set the name and other properties  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Create an Association  
  
#### To create an association  
  
1.  Obtain the owner of the association, which is usually the package or model containing the source end of the relationship.  
  
2.  Invoke the required Create method on the owner.  
  
3.  Set the relationship's properties such as its name.  
  
     For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
4.  Set the properties of each end of the relationship. There are always two <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Create a Generalization  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Delete an Element, Relationship, or Generalization from the Model  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 When you delete an element from a model:  
  
-   Every relationship that links to it is also deleted.  
  
-   Every shape that represented it on a diagram is also deleted.  
  
## See Also  
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [How to: Display a Model on Diagrams](../vs140/display-a-uml-model-on-diagrams.md)