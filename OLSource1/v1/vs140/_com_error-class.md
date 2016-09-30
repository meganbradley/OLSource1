---
title: "_com_error Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_com_error class"
ms.assetid: 70dafa69-b1fb-4a5c-9249-e857e0793d42
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_error Class
**Microsoft Specific**  
  
 A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object represents an exception condition detected by the error-handling wrapper functions in the header files generated from the type library or by one of the COM support classes. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class encapsulates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> error code and any associated <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
### Construction  
  
|||  
|-|-|  
|[_com_error](../vs140/_com_error--_com_error.md)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/_com_error--operator-=.md)|Assigns an existing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to another.|  
  
### Extractor Functions  
  
|||  
|-|-|  
|[Error](../vs140/_com_error--error.md)|Retrieves the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> passed to the constructor.|  
|[ErrorInfo](../vs140/_com_error--errorinfo.md)|Retrieves the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object passed to the constructor.|  
|[WCode](../vs140/_com_error--wcode.md)|Retrieves the 16-bit error code mapped into the encapsulated <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
### IErrorInfo Functions  
  
|||  
|-|-|  
|[Description](../vs140/_com_error--description.md)|Calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function.|  
|[HelpContext](../vs140/_com_error--helpcontext.md)|Calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function.|  
|[HelpFile](../vs140/_com_error--helpfile.md)|Calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function|  
|[Source](../vs140/_com_error--source.md)|Calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function.|  
|[GUID](../vs140/_com_error--guid.md)|Calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function.|  
  
### Format Message Extractor  
  
|||  
|-|-|  
|[ErrorMessage](../vs140/_com_error--errormessage.md)|Retrieves the string message for HRESULT stored in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### ExepInfo.wCode to HRESULT Mappers  
  
|||  
|-|-|  
|[HRESULTToWCode](../vs140/_com_error--hresulttowcode.md)|Maps 32-bit <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to 16-bit <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[WCodeToHRESULT](../vs140/_com_error--wcodetohresult.md)|Maps 16-bit <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to 32-bit <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
## END Microsoft Specific  
  
## Requirements  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> comdef.h  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> comsuppw.lib or comsuppwd.lib (see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) for more information)  
  
## See Also  
 [Compiler COM Support Classes](../vs140/compiler-com-support-classes.md)   
 [IErrorInfo Interface](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447)