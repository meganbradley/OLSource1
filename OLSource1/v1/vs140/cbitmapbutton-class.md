---
title: "CBitmapButton Class"
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
  - "CBitmapButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "buttons, bitmap"
  - "CBitmapButton class"
  - "bitmaps, button controls"
ms.assetid: 9ad6cb45-c3c4-4fb1-96d3-1fe3df7bbcfc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmapButton Class
Creates pushbutton controls labeled with bitmapped images instead of text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CBitmapButton::CBitmapButton](#cbitmapbutton__cbitmapbutton)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CBitmapButton::AutoLoad](#cbitmapbutton__autoload)|Associates a button in a dialog box with an object of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class, loads the bitmap(s) by name, and sizes the button to fit the bitmap.|  
|[CBitmapButton::LoadBitmaps](#cbitmapbutton__loadbitmaps)|Initializes the object by loading one or more named bitmap resources from the application's resource file and attaching the bitmaps to the object.|  
|[CBitmapButton::SizeToContent](#cbitmapbutton__sizetocontent)|Sizes the button to accommodate the bitmap.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects contain up to four bitmaps, which contain images for the different states a button can assume: up (or normal), down (or selected), focused, and disabled. Only the first bitmap is required; the others are optional.  
  
 Bitmap-button images include the border around the image as well as the image itself. The border typically plays a part in showing the state of the button. For example, the bitmap for the focused state usually is like the one for the up state but with a dashed rectangle inset from the border or a thick solid line at the border. The bitmap for the disabled state usually resembles the one for the up state but has lower contrast (like a dimmed or grayed menu selection).  
  
 These bitmaps can be of any size, but all are treated as if they were the same size as the bitmap for the up state.  
  
 Various applications demand different combinations of bitmap images:  
  
|Up|Down|Focused|Disabled|Application|  
|--------|----------|-------------|--------------|-----------------|  
|×||||Bitmap|  
|×|×|||Button without **WS_TABSTOP** style|  
|×|×|×|×|Dialog button with all states|  
|×|×|×||Dialog button with **WS_TABSTOP** style|  
  
 When creating a bitmap-button control, set the **BS_OWNERDRAW** style to specify that the button is owner-drawn. This causes Windows to send the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> messages for the button; the framework handles these messages and manages the appearance of the button for you.  
  
### To create a bitmap-button control in a window's client area  
  
1.  Create one to four bitmap images for the button.  
  
2.  Construct the [CBitmapButton](#cbitmapbutton__cbitmapbutton) object.  
  
3.  Call the [Create](../vs140/cbutton-class.md#cbutton__create) function to create the Windows button control and attach it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
4.  Call the [LoadBitmaps](#cbitmapbutton__loadbitmaps) member function to load the bitmap resources after the bitmap button is constructed.  
  
### To include a bitmap-button control in a dialog box  
  
1.  Create one to four bitmap images for the button.  
  
2.  Create a dialog template with an owner-draw button positioned where you want the bitmap button. The size of the button in the template does not matter.  
  
3.  Set the button's caption to a value such as " **MYIMAGE**" and define a symbol for the button such as **IDC_MYIMAGE**.  
  
4.  In your application's resource script, give each of the images created for the button an ID constructed by appending one of the letters "U," "D," "F," or "X" (for up, down, focused, and disabled) to the string used for the button caption in step 3. For the button caption " **MYIMAGE**," for example, the IDs would be " **MYIMAGEU**," " **MYIMAGED**," " **MYIMAGEF**," and " **MYIMAGEX**." You **must** specify the ID of your bitmaps within double quotes. Otherwise the resource editor will assign an integer to the resource and MFC will fail when loading the image.  
  
5.  In your application's dialog class (derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), add a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member object.  
  
6.  In the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object's [OnInitDialog](../vs140/cdialog-class.md#cdialog__oninitdialog) routine, call the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object's [AutoLoad](#cbitmapbutton__autoload) function, using as parameters the button's control ID and the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object's **this** pointer.  
  
 If you want to handle Windows notification messages, such as **BN_CLICKED**, sent by a bitmap-button control to its parent (usually a class derived from **CDialog)**, add to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived object a message-map entry and message-handler member function for each message. The notifications sent by a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object are the same as those sent by a [CButton](../vs140/cbutton-class.md) object.  
  
 The class [CToolBar](../vs140/ctoolbar-class.md) takes a different approach to bitmap buttons.  
  
 For more information on <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CButton](../vs140/cbutton-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="cbitmapbutton__autoload">\</a>  CBitmapButton::AutoLoad  
 Associates a button in a dialog box with an object of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class, loads the bitmap(s) by name, and sizes the button to fit the bitmap.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The button's control ID.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Pointer to the object that owns the button.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function to initialize an owner-draw button in a dialog box as a bitmap button. Instructions for using this function are in the remarks for the [CBitmapButton](../vs140/cbitmapbutton-class.md) class.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#75](../vs140/codesnippet/CPP/cbitmapbutton-class_1.cpp)]  
  
##  \<a name="cbitmapbutton__cbitmapbutton">\</a>  CBitmapButton::CBitmapButton  
 Creates a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 After creating the C++ <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object, call [CButton::Create](../vs140/cbutton-class.md#cbutton__create) to create the Windows button control and attach it to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#57](../vs140/codesnippet/CPP/cbitmapbutton-class_2.cpp)]  
  
##  \<a name="cbitmapbutton__loadbitmaps">\</a>  CBitmapButton::LoadBitmaps  
 Use this function when you want to load bitmap images identified by their resource names or ID numbers, or when you cannot use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function because, for example, you are creating a bitmap button that is not part of a dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *lpszBitmapResource*  
 Points to the null-terminated string that contains the name of the bitmap for a bitmap button's normal or "up" state. Required.  
  
 *lpszBitmapResourceSel*  
 Points to the null-terminated string that contains the name of the bitmap for a bitmap button's selected or "down" state. May be **NULL**.  
  
 *lpszBitmapResourceFocus*  
 Points to the null-terminated string that contains the name of the bitmap for a bitmap button's focused state. May be **NULL**.  
  
 *lpszBitmapResourceDisabled*  
 Points to the null-terminated string that contains the name of the bitmap for a bitmap button's disabled state. May be **NULL**.  
  
 *nIDBitmapResource*  
 Specifies the resource ID number of the bitmap resource for a bitmap button's normal or "up" state. Required.  
  
 *nIDBitmapResourceSel*  
 Specifies the resource ID number of the bitmap resource for a bitmap button's selected or "down" state. May be 0.  
  
 *nIDBitmapResourceFocus*  
 Specifies the resource ID number of the bitmap resource for a bitmap button's focused state. May be 0.  
  
 *nIDBitmapResourceDisabled*  
 Specifies the resource ID number of the bitmap resource for a bitmap button's disabled state. May be 0.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#58](../vs140/codesnippet/CPP/cbitmapbutton-class_3.cpp)]  
  
##  \<a name="cbitmapbutton__sizetocontent">\</a>  CBitmapButton::SizeToContent  
 Call this function to resize a bitmap button to the size of the bitmap.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCControlLadenDialog#59](../vs140/codesnippet/CPP/cbitmapbutton-class_4.cpp)]  
  
## See Also  
 [MFC Sample CTRLTEST](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)