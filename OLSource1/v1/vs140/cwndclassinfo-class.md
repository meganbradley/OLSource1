---
title: "CWndClassInfo Class"
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
  - "CWndClassInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWndClassInfo class"
ms.assetid: c36fe7e1-75f1-4cf5-a06f-9f59c43fe6fb
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo Class
This class provides methods for registering information for a window class.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CWndClassInfo  
  
```  
  
## Members  
  
### Public Methods  
  
|||  
|-|-|  
|[Register](../vs140/cwndclassinfo--register.md)|Registers the window class.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_atom](../vs140/cwndclassinfo--m_atom.md)|Uniquely identifies the registered window class.|  
|[m_bSystemCursor](../vs140/cwndclassinfo--m_bsystemcursor.md)|Specifies whether the cursor resource refers to a system cursor or to a cursor contained in a module resource.|  
|[m_lpszCursorID](../vs140/cwndclassinfo--m_lpszcursorid.md)|Specifies the name of the cursor resource.|  
|[m_lpszOrigName](../vs140/cwndclassinfo--m_lpszorigname.md)|Contains the name of an existing window class.|  
|[m_szAutoName](../vs140/cwndclassinfo--m_szautoname.md)|Holds an ATL-generated name of the window class.|  
|[m_wc](../vs140/cwndclassinfo--m_wc.md)|Maintains window class information in a **WNDCLASSEX** structure.|  
|[pWndProc](../vs140/cwndclassinfo--pwndproc.md)|Points to the window procedure of an existing window class.|  
  
## Remarks  
 `CWndClassInfo` manages the information of a window class. You typically use `CWndClassInfo` through one of three macros, `DECLARE_WND_CLASS`, `DECLARE_WND_CLASS_EX`, or `DECLARE_WND_SUPERCLASS`, as described in the following table:  
  
|Macro|Description|  
|-----------|-----------------|  
|[DECLARE_WND_CLASS](../vs140/declare_wnd_class.md)|`CWndClassInfo` registers information for a new window class.|  
|[DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md)|`CWndClassInfo` registers information for a new window class, including the class parameters.|  
|[DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md)|`CWndClassInfo` registers information for a window class that is based on an existing class but uses a different window procedure. This technique is called superclassing.|  
  
 By default, [CWindowImpl](../vs140/cwindowimpl-class.md) includes the `DECLARE_WND_CLASS` macro to create a window based on a new window class. DECLARE_WND_CLASS provides default styles and background color for the control. If you want to specify the style and background color yourself, derive your class from `CWindowImpl` and include the `DECLARE_WND_CLASS_EX` macro in your class definition.  
  
 If you want to create a window based on an existing window class, derive your class from `CWindowImpl` and include the `DECLARE_WND_SUPERCLASS` macro in your class definition. For example:  
  
 [!code[NVC_ATL_Windowing#43](../vs140/codesnippet/CPP/cwndclassinfo-class_1.h)]  
  
 For more information about window classes, see [Window Classes](http://msdn.microsoft.com/library/windows/desktop/ms632596) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about using windows in ATL, see the article [ATL Window Classes](../vs140/atl-window-classes.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
##  <a name="cwndclassinfo__m_atom"></a>  CWndClassInfo::m_atom  
 Contains the unique identifier for the registered window class.  
  
```  
  
ATOM m_atom;  
  
```  
  
##  <a name="cwndclassinfo__m_bsystemcursor"></a>  CWndClassInfo::m_bSystemCursor  
 If **TRUE**, the system cursor resource will be loaded when the window class is registered.  
  
```  
  
BOOL m_bSystemCursor;  
  
```  
  
### Remarks  
 Otherwise, the cursor resource contained in your module will be loaded.  
  
 `CWndClassInfo` uses `m_bSystemCursor` only when the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro is specified. In this case, `m_bSystemCursor` is initialized to **TRUE**. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
##  <a name="cwndclassinfo__m_lpszcursorid"></a>  CWndClassInfo::m_lpszCursorID  
 Specifies either the name of the cursor resource or the resource identifier in the low-order word and zero in the high-order word.  
  
```  
  
LPCTSTR m_lpszCursorID;  
  
```  
  
### Remarks  
 When the window class is registered, the handle to the cursor identified by `m_lpszCursorID` is retrieved and stored by [m_wc](../vs140/cwndclassinfo--m_wc.md).  
  
 `CWndClassInfo` uses `m_lpszCursorID` only when the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro is specified. In this case, `m_lpszCursorID` is initialized to **IDC_ARROW**. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
##  <a name="cwndclassinfo__m_lpszorigname"></a>  CWndClassInfo::m_lpszOrigName  
 Contains the name of an existing window class.  
  
```  
  
LPCTSTR m_lpszOrigName;  
  
```  
  
### Remarks  
 `CWndClassInfo` uses `m_lpszOrigName` only when you include the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro in your class definition. In this case, `CWndClassInfo` registers a window class based on the class named by `m_lpszOrigName`. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
##  <a name="cwndclassinfo__m_szautoname"></a>  CWndClassInfo::m_szAutoName  
 Holds the name of the window class.  
  
```  
  
TCHAR m_szAutoName[13];  
  
```  
  
### Remarks  
 `CWndClassInfo` uses `m_szAutoName` only if **NULL** is passed for the `WndClassName` parameter to [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md), the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) or [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md). ATL will construct a name when the window class is registered.  
  
##  <a name="cwndclassinfo__m_wc"></a>  CWndClassInfo::m_wc  
 Maintains the window class information in a [WNDCLASSEX](http://msdn.microsoft.com/library/windows/desktop/ms633577) structure.  
  
```  
  
WNDCLASSEX m_wc;  
  
```  
  
### Remarks  
 If you have specified the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro, `m_wc` contains information about a new window class.  
  
 If you have specified the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro, `m_wc` contains information about a superclass — a window class that is based on an existing class but uses a different window procedure. [m_lpszOrigName](../vs140/cwndclassinfo--m_lpszorigname.md) and [pWndProc](../vs140/cwndclassinfo--pwndproc.md) save the existing window class's name and window procedure, respectively.  
  
##  <a name="cwndclassinfo__pwndproc"></a>  CWndClassInfo::pWndProc  
 Points to the window procedure of an existing window class.  
  
```  
  
WNDPROC pWndProc;  
  
```  
  
### Remarks  
 `CWndClassInfo` uses `pWndProc` only when you include the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro in your class definition. In this case, `CWndClassInfo` registers a window class that is based on an existing class but uses a different window procedure. The existing window class's window procedure is saved in `pWndProc`. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
##  <a name="cwndclassinfo__register"></a>  CWndClassInfo::Register  
 Called by [CWindowImpl::Create](../vs140/cwindowimpl--create.md) to register the window class if it has not yet been registered.  
  
```  
  
ATOM Register(  
      WNDPROC*  pProc  
   );  
  
```  
  
### Parameters  
 `pProc`  
 [out] Specifies the original window procedure of an existing window class.  
  
### Return Value  
 If successful, an atom that uniquely identifies the window class being registered. Otherwise, 0.  
  
### Remarks  
 If you have specified the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro, `Register` registers a new window class. In this case, the `pProc` parameter is not used.  
  
 If you have specified the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro, `Register` registers a superclass — a window class that is based on an existing class but uses a different window procedure. The existing window class's window procedure is returned in `pProc`.  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)