---
title: "Error Statement"
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
  - "vb.error"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Error statement, syntax"
  - "Error statement"
  - "Error keyword"
  - "run-time errors, codes"
  - "errors [Visual Basic], simulating"
ms.assetid: 85cd5c59-5224-4f02-aaf5-fcfefab17a29
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Statement
Simulates the occurrence of an error.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Can be any valid error number.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement is supported for backward compatibility. In new code, especially when creating objects, use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method to generate run-time errors.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is defined, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement calls the error handler after the properties of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object are assigned the following default values:  
  
|Property|Value|  
|--------------|-----------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Value specified as argument to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement. Can be any valid error number.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Name of the current Visual Basic project.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|String expression corresponding to the return value of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function for the specified <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, if this string exists. If the string does not exist, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> contains a zero-length string ("").|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The fully qualified drive, path, and file name of the appropriate Visual Basic Help file.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The appropriate Visual Basic Help file context ID for the error corresponding to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Zero.|  
  
 If no error handler exists, or if none is enabled, an error message is created and displayed from the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object properties.  
  
> [!NOTE]
>  Some Visual Basic host applications cannot create objects. See your host application's documentation to determine whether it can create classes and objects.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement to generate error number 11.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 \<xref:Microsoft.VisualBasic.ErrObject.Clear*>   
 \<xref:Microsoft.VisualBasic.Information.Err*>   
 \<xref:Microsoft.VisualBasic.ErrObject.Raise*>   
 [On Error Statement](../vs140/on-error-statement--visual-basic-.md)   
 [Resume Statement](../vs140/resume-statement.md)   
 [Error Messages (Visual Basic)](../vs140/error-messages--visual-basic-.md)