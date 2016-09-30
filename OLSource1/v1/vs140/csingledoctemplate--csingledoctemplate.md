---
title: "CSingleDocTemplate::CSingleDocTemplate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CSingleDocTemplate.CSingleDocTemplate"
  - "CSingleDocTemplate::CSingleDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSingleDocTemplate class, construction/destruction"
  - "CSingleDocTemplate class, constructor"
ms.assetid: 7c6a6ce4-5890-4a80-840e-d7277e967691
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSingleDocTemplate::CSingleDocTemplate
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a placeholder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information about the substrings, see [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md). This string resource is found in the application's resource file. For example:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 For more information about these resource types, see the [String Editor](../vs140/string-editor.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object of the frame window class. This class can be a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived class, or it can be <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> itself if you want default behavior for your main frame window.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object of the view class. This class is a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived class you define to display your documents.  
  
## Remarks  
 Dynamically allocate a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object and pass it to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function of your application class.  
  
## Example  
 [!code[NVC_MFCDocViewSDI#13](../vs140/codesnippet/CPP/csingledoctemplate--csingledoctemplate_1.cpp)]  
  
 [!code[NVC_MFCDocViewSDI#14](../vs140/codesnippet/CPP/csingledoctemplate--csingledoctemplate_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CSingleDocTemplate Class](../vs140/csingledoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)