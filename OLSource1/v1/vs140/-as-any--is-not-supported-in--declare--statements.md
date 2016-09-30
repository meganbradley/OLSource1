---
title: "&#39;As Any&#39; is not supported in &#39;Declare&#39; statements"
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
  - "bc30828"
  - "vbc30828"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30828"
ms.assetid: 7e5cf519-8b64-4ac5-8116-705fe26c846d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;As Any&#39; is not supported in &#39;Declare&#39; statements
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> data type was used with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements in Visual Basic 6.0 and earlier versions to permit the use of arguments that could contain any type of data. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supports overloading, however, and so makes the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data type obsolete.  
  
 **Error ID:** BC30828  
  
### To correct this error  
  
1.  Declare parameters of the specific type you want to use; for example.  
  
     [!code[VbVbalrStatements#95](../vs140/codesnippet/VisualBasic/-as-any--is-not-supported-in--declare--statements_1.vb)]  
  
2.  Use the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute to specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is expected by the procedure being called.  
  
     [!code[VbVbalrStatements#96](../vs140/codesnippet/VisualBasic/-as-any--is-not-supported-in--declare--statements_2.vb)]  
  
## See Also  
 \<xref:System.Runtime.InteropServices.MarshalAsAttribute*>   
 [Walkthrough: Calling Windows APIs](../vs140/walkthrough--calling-windows-apis--visual-basic-.md)   
 [Declare Statement](../vs140/declare-statement.md)   
 [Creating Prototypes in Managed Code](assetId:///ecdcf25d-cae3-4f07-a2b6-8397ac6dc42d)