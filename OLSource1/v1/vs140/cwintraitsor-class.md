---
title: "CWinTraitsOR Class"
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
  - "ATL.CWinTraitsOR"
  - "ATL::CWinTraitsOR"
  - "CWinTraitsOR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinTraitsOR class"
  - "window styles, default values for ATL"
ms.assetid: 1eb7b1e8-a9bd-411b-a30a-35a8a10af989
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinTraitsOR Class
This class provides a method for standardizing the styles used when creating a window object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Default window styles.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Default extended window styles.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinTraitsOR::GetWndExStyle](../vs140/cwintraitsor--getwndexstyle.md)|Retrieves the extended styles for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|[CWinTraitsOR::GetWndStyle](../vs140/cwintraitsor--getwndstyle.md)|Retrieves the standard styles for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This [window traits](../vs140/understanding-window-traits.md) class provides a simple method for standardizing the styles used for the creation of an ATL window object. Use a specialization of this class as a template parameter to [CWindowImpl](../vs140/cwindowimpl-class.md) or another of ATL's window classes to specify the minimum set of standard and extended styles to be used for instances of that window class.  
  
 Use a specialization of this template if you want to ensure that certain styles are set for all instances of the window class while permitting other styles to be set on a per-instance basis in the call to [CWindowImpl::Create](../vs140/cwindowimpl--create.md).  
  
 If you want to provide default window styles that will be used only when no other styles are specified in the call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, use [CWinTraits](../vs140/cwintraits-class.md) instead.  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="cwintraitsor__getwndstyle">\</a>  CWinTraitsOR::GetWndStyle  
 Call this function to retrieve a combination (using the logical OR operator) of the standard styles of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object and the default styles specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Styles used for creation of a window.  
  
### Return Value  
 A combination of styles that are passed in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the default ones specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, using the logical OR operator.  
  
##  \<a name="cwintraitsor__getwndexstyle">\</a>  CWinTraitsOR::GetWndExStyle  
 Call this function to retrieve a combination (using the logical OR operator) of the extended styles of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object and the default styles specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Extended styles used for creation of a window.  
  
### Return Value  
 A combination of extended styles that are passed in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and default ones specified by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, using the logical OR operator  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Understanding Window Traits](../vs140/understanding-window-traits.md)