---
title: "CMFCToolBarMenuButton Class"
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
  - "CMFCToolBarMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarMenuButton class"
ms.assetid: cfa50176-7e4b-4527-9904-86a1b48fc1bc
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton Class
A toolbar button that contains a pop-up menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarMenuButton::CMFCToolbarMenuButton](#cmfctoolbarmenubutton__cmfctoolbarmenubutton)|Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarMenuButton::CompareWith](#cmfctoolbarmenubutton__comparewith)|Compares this instance with the provided <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object. (Overrides [CMFCToolBarButton::CompareWith](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__comparewith).)|  
|[CMFCToolBarMenuButton::CopyFrom](#cmfctoolbarmenubutton__copyfrom)|Copies the properties of another toolbar button to the current button. (Overrides [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__copyfrom).)|  
|[CMFCToolBarMenuButton::CreateFromMenu](#cmfctoolbarmenubutton__createfrommenu)|Initializes the toolbar menu from a Windows menu handle.|  
|[CMFCToolBarMenuButton::CreateMenu](#cmfctoolbarmenubutton__createmenu)|Creates a Windows menu that consists of the commands in the toolbar menu. Returns a handle to the Windows menu.|  
|[CMFCToolBarMenuButton::CreatePopupMenu](#cmfctoolbarmenubutton__createpopupmenu)|Creates a pop-up menu object ( [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)) to display the toolbar menu.|  
|[CMFCToolBarMenuButton::EnableQuickCustomize](#cmfctoolbarmenubutton__enablequickcustomize)||  
|[CMFCToolBarMenuButton::GetCommands](#cmfctoolbarmenubutton__getcommands)|Gives read-only access to the list of commands in the toolbar menu.|  
|[CMFCToolBarMenuButton::GetImageRect](#cmfctoolbarmenubutton__getimagerect)|Retrieves the bounding rectangle for the button image.|  
|[CMFCToolBarMenuButton::GetPaletteRows](#cmfctoolbarmenubutton__getpaletterows)|Returns the number of rows in the pop-up menu when the menu is in palette mode.|  
|[CMFCToolBarMenuButton::GetPopupMenu](#cmfctoolbarmenubutton__getpopupmenu)|Returns a pointer to the pop-up menu object that is associated with the button.|  
|[CMFCToolBarMenuButton::HasButton](#cmfctoolbarmenubutton__hasbutton)||  
|[CMFCToolBarMenuButton::HaveHotBorder](#cmfctoolbarmenubutton__havehotborder)|Determines whether a border of the button is displayed when a user selects the button. (Overrides [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__havehotborder).)|  
|[CMFCToolBarMenuButton::IsBorder](#cmfctoolbarmenubutton__isborder)||  
|[CMFCToolBarMenuButton::IsClickedOnMenu](#cmfctoolbarmenubutton__isclickedonmenu)||  
|[CMFCToolBarMenuButton::IsDroppedDown](#cmfctoolbarmenubutton__isdroppeddown)|Determines whether the pop-up menu is displayed.|  
|[CMFCToolBarMenuButton::IsEmptyMenuAllowed](#cmfctoolbarmenubutton__isemptymenuallowed)|Called by the framework to determine whether a user can open a submenu from the selected menu item.|  
|[CMFCToolBarMenuButton::IsExclusive](#cmfctoolbarmenubutton__isexclusive)|Determines whether the button is in exclusive mode, that is, whether the pop-up menu remains open even when the user moves the pointer over another toolbar or button.|  
|[CMFCToolBarMenuButton::IsMenuPaletteMode](#cmfctoolbarmenubutton__ismenupalettemode)|Determines whether the pop-up menu is in palette mode.|  
|[CMFCToolBarMenuButton::IsQuickMode](#cmfctoolbarmenubutton__isquickmode)||  
|[CMFCToolBarMenuButton::IsTearOffMenu](#cmfctoolbarmenubutton__istearoffmenu)|Determines whether the pop-up menu has a tear-off bar.|  
|[CMFCToolBarMenuButton::OnAfterCreatePopupMenu](#cmfctoolbarmenubutton__onaftercreatepopupmenu)||  
|[CMFCToolBarMenuButton::OnBeforeDrag](#cmfctoolbarmenubutton__onbeforedrag)|Specifies whether the button can be dragged. (Overrides [CMFCToolBarButton::OnBeforeDrag](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onbeforedrag).)|  
|[CMFCToolBarMenuButton::OnCalculateSize](#cmfctoolbarmenubutton__oncalculatesize)|Called by the framework to calculate the size of the button for the specified device context and docking state. (Overrides [CMFCToolBarButton::OnCalculateSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncalculatesize).)|  
|[CMFCToolBarMenuButton::OnCancelMode](#cmfctoolbarmenubutton__oncancelmode)|Called by the framework to handle the                                         [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615) message. (Overrides [CMFCToolBarButton::OnCancelMode](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncancelmode).)|  
|[CMFCToolBarMenuButton::OnChangeParentWnd](#cmfctoolbarmenubutton__onchangeparentwnd)|Called by the framework when the button is inserted into a new toolbar. (Overrides [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd).)|  
|[CMFCToolBarMenuButton::OnClick](#cmfctoolbarmenubutton__onclick)|Called by the framework when the user clicks the mouse button. (Overrides [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick).)|  
|[CMFCToolBarMenuButton::OnClickMenuItem](#cmfctoolbarmenubutton__onclickmenuitem)|Called by the framework when the user selects an item in the pop-up menu.|  
|[CMFCToolBarMenuButton::OnContextHelp](#cmfctoolbarmenubutton__oncontexthelp)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> message. (Overrides [CMFCToolBarButton::OnContextHelp](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncontexthelp).)|  
|[CMFCToolBarMenuButton::OnDraw](#cmfctoolbarmenubutton__ondraw)|Called by the framework to draw the button by using the specified styles and options. (Overrides [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondraw).)|  
|[CMFCToolBarMenuButton::OnDrawOnCustomizeList](#cmfctoolbarmenubutton__ondrawoncustomizelist)|Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box. (Overrides [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist).)|  
|[CMFCToolBarMenuButton::OpenPopupMenu](#cmfctoolbarmenubutton__openpopupmenu)|Called by the framework when the user opens the pop-up menu.|  
|[CMFCToolBarMenuButton::ResetImageToDefault](#cmfctoolbarmenubutton__resetimagetodefault)|Sets to the default value the image that is associated with the button. (Overrides [CMFCToolBarButton::ResetImageToDefault](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__resetimagetodefault).)|  
|[CMFCToolBarMenuButton::SaveBarState](#cmfctoolbarmenubutton__savebarstate)|Saves the state of the toolbar button. (Overrides [CMFCToolBarButton::SaveBarState](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__savebarstate).)|  
|[CMFCToolBarMenuButton::Serialize](#cmfctoolbarmenubutton__serialize)|Reads this object from an archive or writes it to an archive. (Overrides [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__serialize).)|  
|[CMFCToolBarMenuButton::SetACCData](#cmfctoolbarmenubutton__setaccdata)|Populates the provided <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object with accessibility data from the toolbar button. (Overrides [CMFCToolBarButton::SetACCData](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__setaccdata).)|  
|[CMFCToolBarMenuButton::SetMenuOnly](#cmfctoolbarmenubutton__setmenuonly)|Specifies whether the button can be added to a toolbar.|  
|[CMFCToolBarMenuButton::SetMenuPaletteMode](#cmfctoolbarmenubutton__setmenupalettemode)|Specifies whether the pop-up menu is in palette mode.|  
|[CMFCToolBarMenuButton::SetMessageWnd](#cmfctoolbarmenubutton__setmessagewnd)||  
|[CMFCToolBarMenuButton::SetRadio](#cmfctoolbarmenubutton__setradio)|Forces the toolbar menu button to display an icon indicating that it is selected.|  
|[CMFCToolBarMenuButton::SetTearOff](#cmfctoolbarmenubutton__settearoff)|Specifies a tear-off bar ID for the pop-up menu.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarMenuButton::DrawDocumentIcon](#cmfctoolbarmenubutton__drawdocumenticon)|Draws an icon on the menu button.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarMenuButton::m_bAlwaysCallOwnerDraw](#cmfctoolbarmenubutton__m_balwayscallownerdraw)|If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the framework always calls [CFrameWndEx::OnDrawMenuImage](../vs140/cframewndex-class.md#cframewndex__ondrawmenuimage) when a button is drawn.|  
  
## Remarks  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> can appear as a menu, a menu item that has a sub-menu, a button that either executes a command or displays a menu, or a button that displays only a menu. You determine the behavior and appearance of the menu button by specifying parameters such as the image, text, menu handle, and command ID that is associated with the button in the constructor <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 A custom class derived from the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class must use the [DECLARE_SERIAL](../vs140/declare_serial.md) macro. The [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md) macro generates an error when the application closes.  
  
## Example  
 The following example demonstrates how to configure a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object. The code illustrates how to specify that the drop-down menu is in palette mode, and specify the ID for the tear-off bar that is created when the user drags the menu button off of a menu bar. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#10](../vs140/codesnippet/CPP/cmfctoolbarmenubutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md)  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
##  \<a name="cmfctoolbarmenubutton__cmfctoolbarmenubutton">\</a>  CMFCToolBarMenuButton::CMFCToolBarMenuButton  
 Constructs a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object to be copied into this <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The ID of the command to execute when a user clicks the button; or ( <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>)-1 for a menu button that does not directly execute a command.  
  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A handle to a menu; or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the button does not have a menu.  
  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Index of the image for the button; or -1 if this button does not have an icon or uses the icon for the command specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. The index is the same for each <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object in your application.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The text of the toolbar menu button.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if the button displays a user-defined image; <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> if the button displays a predefined image associated with the command specified by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is a valid command ID, the button performs that command when the user clicks it. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is a valid menu handle, the button provides a drop-down menu when it appears in a toolbar or a submenu when it appears in a menu. If both <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> are valid, the button is a split-button with a portion that will perform the command when the user clicks on it and a portion with a down arrow that will drop-down a menu when the user clicks on it. However, if <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is valid, a user will not be able to click the button to perform a command when the button is inserted into a menu.  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#9](../vs140/codesnippet/CPP/cmfctoolbarmenubutton-class_2.cpp)]  
  
##  \<a name="cmfctoolbarmenubutton__comparewith">\</a>  CMFCToolBarMenuButton::CompareWith  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__copyfrom">\</a>  CMFCToolBarMenuButton::CopyFrom  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__createfrommenu">\</a>  CMFCToolBarMenuButton::CreateFromMenu  
 Initializes the toolbar menu from a Windows menu handle.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A handle to a menu.  
  
### Remarks  
 A toolbar menu button can display a drop-down submenu.  
  
 The framework calls this method to initialize the commands in the submenu from a menu.  
  
##  \<a name="cmfctoolbarmenubutton__createmenu">\</a>  CMFCToolBarMenuButton::CreateMenu  
 Creates a menu that consists of the commands in the toolbar menu. Returns a handle to the menu.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A handle to the menu if success. <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if the list of commands associated with the toolbar menu button is empty.  
  
### Remarks  
 You can override this method in a derived class to customize the way the menu is generated.  
  
##  \<a name="cmfctoolbarmenubutton__createpopupmenu">\</a>  CMFCToolBarMenuButton::CreatePopupMenu  
 Creates a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object to display the toolbar menu.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object that displays the drop-down menu associated with the toolbar menu button.  
  
### Remarks  
 This method is called by the framework to prepare the display of the drop-down menu associated with the button.  
  
 The default implementation just constructs and returns a new <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object. Override this method if you want to use a derived type of [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) or to perform additional initialization.  
  
##  \<a name="cmfctoolbarmenubutton__drawdocumenticon">\</a>  CMFCToolBarMenuButton::DrawDocumentIcon  
 Draws a document icon on the menu button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer to the device context.  
  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Coordinates of the image bounding rectangle.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A handle to the icon.  
  
### Remarks  
 This method takes a document icon and draws it on the menu button, centered in the area specified by <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarmenubutton__enablequickcustomize">\</a>  CMFCToolBarMenuButton::EnableQuickCustomize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__hasbutton">\</a>  CMFCToolBarMenuButton::HasButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__havehotborder">\</a>  CMFCToolBarMenuButton::HaveHotBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__isborder">\</a>  CMFCToolBarMenuButton::IsBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__isclickedonmenu">\</a>  CMFCToolBarMenuButton::IsClickedOnMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__isquickmode">\</a>  CMFCToolBarMenuButton::IsQuickMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__getcommands">\</a>  CMFCToolBarMenuButton::GetCommands  
 Gives read-only access to the list of commands in the toolbar menu.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A const reference to a [CObList](../vs140/coblist-class.md) object, which contains a collection of [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md) objects.  
  
### Remarks  
 A toolbar menu button can display a submenu. You can provide the list of commands in the submenu in the constructor or in [CreateFromMenu](#cmfctoolbarmenubutton__createfrommenu) as a handle to a menu ( <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>). The menu is converted to a list of objects that are derived from [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md) and stored in the internal <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object. You can access this list by calling this method.  
  
##  \<a name="cmfctoolbarmenubutton__getimagerect">\</a>  CMFCToolBarMenuButton::GetImageRect  
 Retrieves the bounding rectangle for the button image.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object that receives the coordinates of the image bounding rectangle.  
  
##  \<a name="cmfctoolbarmenubutton__getpaletterows">\</a>  CMFCToolBarMenuButton::GetPaletteRows  
 Returns the number of rows in the drop-down menu when the menu is in palette mode.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The number of rows in the palette.  
  
### Remarks  
 When the menu button is set to palette mode, menu items will appear in multiple columns with only a limited number of rows. Call this method to obtain the number of rows. You can enable or disable palette mode and specify the number of rows using [SetMenuPaletteMode](#cmfctoolbarmenubutton__setmenupalettemode).  
  
##  \<a name="cmfctoolbarmenubutton__getpopupmenu">\</a>  CMFCToolBarMenuButton::GetPopupMenu  
 Returns a pointer to the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object that represents the drop-down menu of the button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object that was created when the framework drew the submenu of the toolbar menu button; <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> if no submenu is displayed.  
  
### Remarks  
 When a toolbar menu button displays a drop-down menu, the button creates a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object to represent the menu. Call this method to obtain a pointer to the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object. You should not store the returned pointer, because it is temporary and becomes invalid when the user closes the drop-down menu.  
  
##  \<a name="cmfctoolbarmenubutton__isdroppeddown">\</a>  CMFCToolBarMenuButton::IsDroppedDown  
 Indicates whether the pop-up menu is currently displayed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if the toolbar menu button displays its submenu; otherwise <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarmenubutton__isemptymenuallowed">\</a>  CMFCToolBarMenuButton::IsEmptyMenuAllowed  
 Specifies whether menu items shows empty submenus.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> if the framework opens a submenu from the currently selected menu item even when the submenu is empty; otherwise <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when a user tries to open the submenu from the currently selected menu item. If the submenu is empty and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, the submenu will not open.  
  
 The default implementation returns <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. Override this method to customize this behavior.  
  
##  \<a name="cmfctoolbarmenubutton__isexclusive">\</a>  CMFCToolBarMenuButton::IsExclusive  
 Indicates whether the button is in exclusive mode.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> if the button is working in exclusive mode; otherwise <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Remarks  
 When a user opens a popup menu for a button and then moves the mouse pointer over another toolbar or menu button, the popup menu closes unless the button is in exclusive mode.  
  
 The default implementation always returns <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. Override this method in a derived class if you want to turn on exclusive mode.  
  
##  \<a name="cmfctoolbarmenubutton__ismenupalettemode">\</a>  CMFCToolBarMenuButton::IsMenuPaletteMode  
 Determines whether the drop-down menu is in palette mode.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if the palette mode is enabled, otherwise <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Remarks  
 When the menu button is set to palette mode, menu items appear in multiple columns with only a limited number of rows. Call this method to obtain the number of rows. You can enable or disable the palette mode by calling [SetMenuPaletteMode](#cmfctoolbarmenubutton__setmenupalettemode).  
  
##  \<a name="cmfctoolbarmenubutton__istearoffmenu">\</a>  CMFCToolBarMenuButton::IsTearOffMenu  
 Indicates whether the drop-down menu has a tear-off bar.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> if the toolbar menu button has a tear-off bar; otherwise <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Remarks  
 To enable the tear-off feature and set the tear-off bar ID, call [CMFCToolBarMenuButton::SetTearOff](#cmfctoolbarmenubutton__settearoff).  
  
##  \<a name="cmfctoolbarmenubutton__m_balwayscallownerdraw">\</a>  CMFCToolBarMenuButton::m_bAlwaysCallOwnerDraw  
 Specifies whether the framework always calls [CFrameWndEx::OnDrawMenuImage](../vs140/cframewndex-class.md#cframewndex__ondrawmenuimage) when a button is drawn.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 When this member variable is set to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, the button always calls [CFrmWndEx::OnDrawMenuImage](../vs140/cframewndex-class.md#cframewndex__ondrawmenuimage) method to display the image on the button. When <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, the button itself draws the image if the image is predefined. Otherwise, it calls <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarmenubutton__onaftercreatepopupmenu">\</a>  CMFCToolBarMenuButton::OnAfterCreatePopupMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__onbeforedrag">\</a>  CMFCToolBarMenuButton::OnBeforeDrag  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__oncalculatesize">\</a>  CMFCToolBarMenuButton::OnCalculateSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__oncancelmode">\</a>  CMFCToolBarMenuButton::OnCancelMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__onchangeparentwnd">\</a>  CMFCToolBarMenuButton::OnChangeParentWnd  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__onclick">\</a>  CMFCToolBarMenuButton::OnClick  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__onclickmenuitem">\</a>  CMFCToolBarMenuButton::OnClickMenuItem  
 Called by the framework when the user selects an item in the drop-down menu.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the framework should continue the default menu item processing; otherwise <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. The default implementation always returns <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
### Remarks  
 When the user clicks a menu item, the framework executes a command that is associated with that item.  
  
 To customize the menu item processing, override <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> in a class derived from <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> class. You must also override [CMainFrame::OnShowPopupMenu](../vs140/cframewndex-class.md#cframewndex__onshowpopupmenu) and replace the menu buttons that require special processing with instances of the derived class.  
  
##  \<a name="cmfctoolbarmenubutton__oncontexthelp">\</a>  CMFCToolBarMenuButton::OnContextHelp  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__ondraw">\</a>  CMFCToolBarMenuButton::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__ondrawoncustomizelist">\</a>  CMFCToolBarMenuButton::OnDrawOnCustomizeList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__openpopupmenu">\</a>  CMFCToolBarMenuButton::OpenPopupMenu  
 Called by the framework when the user opens the drop-down menu of a toolbar menu button.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Specifies the window that receives the drop-down menu commands. It can be <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> only if the toolbar menu button has a parent window.  
  
### Return Value  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object was created and opened successfully; otherwise <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is called by the framework when the user opens a drop-down menu from a toolbar menu button.  
  
##  \<a name="cmfctoolbarmenubutton__resetimagetodefault">\</a>  CMFCToolBarMenuButton::ResetImageToDefault  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__savebarstate">\</a>  CMFCToolBarMenuButton::SaveBarState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when it creates a toolbar button as the result of a drag-and-drop operation. This method calls the [CMFCPopupMenu::SaveState](../vs140/cmfcpopupmenu-class.md#cmfcpopupmenu__savestate) method of the top-level pop-up menu, which causes the parent button of the pop-up menu to recreate its menu.  
  
##  \<a name="cmfctoolbarmenubutton__serialize">\</a>  CMFCToolBarMenuButton::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__setaccdata">\</a>  CMFCToolBarMenuButton::SetACCData  
 Sets the accessibility data for the ribbon element.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The parent window for the ribbon element.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The accessibility data for the ribbon element.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method sets the accessibility data for the ribbon element and always returns <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. Override this method to set the accessibility data and return a value that indicates success or failure.  
  
##  \<a name="cmfctoolbarmenubutton__setmenuonly">\</a>  CMFCToolBarMenuButton::SetMenuOnly  
 Specifies whether the button is drawn as a menu button or a split button when it has both a valid command ID and a submenu.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> to show this button as a menu button when it has both a valid command ID and a submenu, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> to show this button as a split button when it has both a valid command ID and a submenu.  
  
### Remarks  
 Typically, when a toolbar menu button has both a submenu and a command ID, the menu appears to be a split button that has a main button and an attached down arrow button. If you call this method and <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, the button instead appears to be a single menu button with a down arrow in the button. When the user clicks the arrow in either mode, the submenu opens, and when the user clicks the non-arrow part of the button in either mode the framework executes the command .  
  
##  \<a name="cmfctoolbarmenubutton__setmenupalettemode">\</a>  CMFCToolBarMenuButton::SetMenuPaletteMode  
 Specifies whether the drop-down menu is in palette mode.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Specifies whether the drop-down menu is in palette mode.  
  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Number of rows in palette.  
  
### Remarks  
 In the palette mode, all menu items are displayed as a multicolumn palette. You specify the number of rows by using <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarmenubutton__setmessagewnd">\</a>  CMFCToolBarMenuButton::SetMessageWnd  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarmenubutton__setradio">\</a>  CMFCToolBarMenuButton::SetRadio  
 Sets the toolbar menu button to display a radio button style icon when it is checked.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 When the menu button is drawn while it is checked, it calls [CMFCVisualManager::OnDrawMenuCheck](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawmenucheck) to draw a checkmark icon. By default, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> requests that the current visual manager draws a checkbox style checkmark on the menu button. After you call this method, the current visual manager instead draws a radio button style checkmark on the menu button. This change cannot be undone.  
  
 When you call this method and the menu button is currently being displayed, it will refresh.  
  
##  \<a name="cmfctoolbarmenubutton__settearoff">\</a>  CMFCToolBarMenuButton::SetTearOff  
 Specifies the ID of the tear-off bar for the drop-down menu.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Specifies a new tear-off bar ID.  
  
### Remarks  
 Call this method to specify the ID for the tear-off bar that is created when the user drags the menu button off of a menu bar. If the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> parameter is 0, the user cannot tear off the menu button.  
  
 Call [CWinAppEx::EnableTearOffMenus](../vs140/cwinappex-class.md#cwinappex__enabletearoffmenus) to enable the tear-off menu feature in your application.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)