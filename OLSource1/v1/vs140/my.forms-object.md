---
title: "My.Forms Object"
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
  - "My.Forms"
  - "My.MyProject.Forms"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Forms object"
ms.assetid: f6bff4e6-6769-4294-956b-037aa6106d2a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# My.Forms Object
Provides properties for accessing an instance of each Windows form declared in the current project.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object provides an instance of each form in the current project. The name of the property is the same as the name of the form that the property accesses. For information about adding forms to a project, see [How to: Add Windows Forms to a Project](assetId:///3d7bb25f-fd90-47cf-9378-fa0d764686c1).  
  
 You can access the forms provided by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object by using the name of the form, without qualification. Because the property name is the same as the form's type name, this allows you to access a form as if it had a default instance. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object exposes only the forms associated with the current project. It does not provide access to forms declared in referenced DLLs. To access a form that a DLL provides, you must use the qualified name of the form, written as *DllName*.*FormName*.  
  
 You can use the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OpenForms*> property to get a collection of all the application's open forms.  
  
 The object and its properties are available only for Windows applications.  
  
## Properties  
 Each property of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object provides access to an instance of a form in the current project. The name of the property is the same as the name of the form that the property accesses, and the property type is the same as the form's type.  
  
> [!NOTE]
>  If there is a name collision, the property name to access a form is *RootNamespace*_*Namespace*\_*FormName*. For example, consider two forms named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>If one of these forms is in the root namespace <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and in the namespace <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you would access that form through <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object provides access to the instance of the application's main form that was created on startup. For all other forms, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object creates a new instance of the form when it is accessed and stores it. Subsequent attempts to access that property return that instance of the form.  
  
 You can dispose of a form by assigning <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the property for that form. The property setter calls the \<xref:System.Windows.Forms.Form.Close*> method of the form, and then assigns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to the stored value. If you assign any value other than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the property, the setter throws an \<xref:System.ArgumentException*> exception.  
  
 You can test whether a property of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object stores an instance of the form by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator. You can use those operators to check if the value of the property is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Typically, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator has to read the value of the property to perform the comparison. However, if the property currently stores <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the property creates a new instance of the form and then returns that instance. However, the Visual Basic compiler treats the properties of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object differently and allows the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operator to check the status of the property without altering its value.  
  
## Example  
 This example changes the title of the default <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> form.  
  
 [!code[VbVbalrMyForms#2](../vs140/codesnippet/VisualBasic/my.forms-object_1.vb)]  
  
 For this example to work, your project must have a form named <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [How to: Add Windows Forms to a Project](assetId:///3d7bb25f-fd90-47cf-9378-fa0d764686c1).  
  
 This code will work only in a Windows Application project.  
  
## Requirements  
  
### Availability by Project Type  
  
|||  
|-|-|  
|Project type|Available|  
|Windows Application|**Yes**|  
|Class Library|No|  
|Console Application|No|  
|Windows Control Library|No|  
|Web Control Library|No|  
|Windows Service|No|  
|Web Site|No|  
  
## See Also  
 \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OpenForms*>   
 \<xref:System.Windows.Forms.Form*>   
 \<xref:System.Windows.Forms.Form.Close*>   
 [Objects (Visual Basic)](../vs140/objects--visual-basic-.md)   
 [How to: Add Windows Forms to a Project](assetId:///3d7bb25f-fd90-47cf-9378-fa0d764686c1)   
 [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [Accessing Application Forms](../vs140/accessing-application-forms--visual-basic-.md)