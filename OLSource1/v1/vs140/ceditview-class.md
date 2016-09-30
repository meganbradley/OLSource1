---
title: "CEditView Class"
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
  - "CEditView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "text editors, CEditView class"
  - "text editors"
  - "edit controls, classes"
  - "views, classes"
  - "CEditView class"
ms.assetid: bf38255c-fcbe-450c-95b2-3c5e35f86c37
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView Class
A type of view class that provides the functionality of a Windows edit control and can be used to implement simple text-editor functionality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CEditView::CEditView](#ceditview__ceditview)|Constructs an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CEditView::FindText](#ceditview__findtext)|Searches for a string within the text.|  
|[CEditView::GetBufferLength](#ceditview__getbufferlength)|Obtains the length of the character buffer.|  
|[CEditView::GetEditCtrl](#ceditview__geteditctrl)|Provides access to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> portion of a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object (the Windows edit control).|  
|[CEditView::GetPrinterFont](#ceditview__getprinterfont)|Retrieves the current printer font.|  
|[CEditView::GetSelectedText](#ceditview__getselectedtext)|Retrieves the current text selection.|  
|[CEditView::LockBuffer](#ceditview__lockbuffer)|Locks the buffer.|  
|[CEditView::PrintInsideRect](#ceditview__printinsiderect)|Renders text inside a given rectangle.|  
|[CEditView::SerializeRaw](#ceditview__serializeraw)|Serializes a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object to disk as raw text.|  
|[CEditView::SetPrinterFont](#ceditview__setprinterfont)|Sets a new printer font.|  
|[CEditView::SetTabStops](#ceditview__settabstops)|Sets tab stops for both screen display and printing.|  
|[CEditView::UnlockBuffer](#ceditview__unlockbuffer)|Unlocks the buffer.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CEditView::OnFindNext](#ceditview__onfindnext)|Finds next occurrence of a text string.|  
|[CEditView::OnReplaceAll](#ceditview__onreplaceall)|Replaces all occurrences of a given string with a new string.|  
|[CEditView::OnReplaceSel](#ceditview__onreplacesel)|Replaces current selection.|  
|[CEditView::OnTextNotFound](#ceditview__ontextnotfound)|Called when a find operation fails to match any further text.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CEditView::dwStyleDefault](#ceditview__dwstyledefault)|Default style for objects of type **CEditView.**|  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class provides the following additional functions:  
  
-   Print.  
  
-   Find and replace.  
  
 Because class <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a derivative of class <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, objects of class <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> can be used with documents and document templates.  
  
 Each <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> control's text is kept in its own global memory object. Your application can have any number of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects.  
  
 Create objects of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if you want an edit window with the added functionality listed above, or if you want simple text-editor functionality. A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object can occupy the entire client area of a window. Derive your own classes from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to add or modify the basic functionality, or to declare classes that can be added to a document template.  
  
 The default implementation of class <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> handles the following commands: **ID_EDIT_SELECT_ALL**, **ID_EDIT_FIND**, **ID_EDIT_REPLACE**, **ID_EDIT_REPEAT**, and **ID_FILE_PRINT**.  
  
 The default character limit for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is (1024 \* 1024 - 1 = 1048575). This can be changed by calling the **EM_LIMITTEXT** function of the underlying edit control. However, the limits are different depending on the operating system and the type of edit control (single or multiline). For more information on these limits, see                 [EM_LIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761607).  
  
 To change this limit in your control, override the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function for your <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class and insert the following line of code:  
  
 [!code[NVC_MFCDocView#65](../vs140/codesnippet/CPP/ceditview-class_1.cpp)]  
  
 Objects of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (or of types derived from <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) have the following limitations:  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> does not implement true what you see is what you get (WYSIWYG) editing. Where there is a choice between readability on the screen and matching printed output, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> opts for screen readability.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can display text in only a single font. No special character formatting is supported. See class [CRichEditView](../vs140/cricheditview-class.md) for greater capabilities.  
  
-   The amount of text a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> can contain is limited. The limits are the same as for the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> control.  
  
 For more information on <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, see [Derived View Classes Available in MFC](../vs140/derived-view-classes-available-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CCtrlView](../vs140/cctrlview-class.md)  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="ceditview__ceditview">\</a>  CEditView::CEditView  
 Constructs an object of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 After constructing the object, you must call the [CWnd::Create](../vs140/cwnd-class.md#cwnd__create) function before the edit control is used. If you derive a class from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and add it to the template using <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the framework calls both this constructor and the **Create** function.  
  
##  \<a name="ceditview__dwstyledefault">\</a>  CEditView::dwStyleDefault  
 Contains the default style of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Pass this static member as the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter of the **Create** function to obtain the default style for the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
##  \<a name="ceditview__findtext">\</a>  CEditView::FindText  
 Call the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function to search the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object's text buffer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies whether the search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
### Return Value  
 Nonzero if the search text is found; otherwise 0.  
  
### Remarks  
 This function searches the text in the buffer for the text specified by <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, starting at the current selection, in the direction specified by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, and with case sensitivity specified by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. If the text is found, it sets the selection to the found text and returns a nonzero value. If the text is not found, the function returns 0.  
  
 You normally do not need to call the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> function unless you override <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, which calls <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
##  \<a name="ceditview__getbufferlength">\</a>  CEditView::GetBufferLength  
 Call this member function to obtain the number of characters currently in the edit control's buffer, not including the null terminator.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The length of the string in the buffer.  
  
##  \<a name="ceditview__geteditctrl">\</a>  CEditView::GetEditCtrl  
 Call <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to get a reference to the edit control used by the edit view.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This control is of type [CEdit](../vs140/cedit-class.md), so you can manipulate the Windows edit control directly using the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> member functions.  
  
> [!CAUTION]
>  Using the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object can change the state of the underlying Windows edit control. For example, you should not change the tab settings using the [CEdit::SetTabStops](../vs140/cedit-class.md#cedit__settabstops) function because <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> caches these settings for use both in the edit control and in printing. Instead, use [CEditView::SetTabStops](#ceditview__settabstops).  
  
### Example  
 [!code[NVC_MFCDocView#66](../vs140/codesnippet/CPP/ceditview-class_2.cpp)]  
  
##  \<a name="ceditview__getprinterfont">\</a>  CEditView::GetPrinterFont  
 Call <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to get a pointer to a [CFont](../vs140/cfont-class.md) object that describes the current printer font.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object that specifies the current printer font; **NULL** if the printer font has not been set. The pointer may be temporary and should not be stored for later use.  
  
### Remarks  
 If the printer font has not been set, the default printing behavior of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class is to print using the same font used for display.  
  
 Use this function to determine the current printer font. If it is not the desired printer font, use [CEditView::SetPrinterFont](#ceditview__setprinterfont) to change it.  
  
##  \<a name="ceditview__getselectedtext">\</a>  CEditView::GetSelectedText  
 Call <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to copy the selected text into a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object, up to the end of the selection or the character preceding the first carriage-return character in the selection.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object that is to receive the selected text.  
  
##  \<a name="ceditview__lockbuffer">\</a>  CEditView::LockBuffer  
 Call this member function to obtain a pointer to the buffer. The buffer should not be modified.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the edit control's buffer.  
  
##  \<a name="ceditview__onfindnext">\</a>  CEditView::OnFindNext  
 Searches the text in the buffer for the text specified by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, in the direction specified by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, with case sensitivity specified by <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Specifies the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Specifies whether the search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
### Remarks  
 The search starts at the beginning of the current selection and is accomplished through a call to [FindText](#ceditview__findtext). In the default implementation, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> calls [OnTextNotFound](#ceditview__ontextnotfound) if the text is not found.  
  
 Override <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to change the way a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>-derived object searches text. <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> when the user chooses the Find Next button in the standard Find dialog box.  
  
##  \<a name="ceditview__onreplaceall">\</a>  CEditView::OnReplaceAll  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> when the user selects the Replace All button in the standard Replace dialog box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The text to replace the search text.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Specifies whether search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
### Remarks  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> searches the text in the buffer for the text specified by <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, with case sensitivity specified by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. The search starts at the beginning of the current selection. Each time the search text is found, this function replaces that occurrence of the text with the text specified by <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. The search is accomplished through a call to [FindText](#ceditview__findtext). In the default implementation, [OnTextNotFound](#ceditview__ontextnotfound) is called if the text is not found.  
  
 If the current selection does not match <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, the selection is updated to the first occurrence of the text specified by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> and a replace is not performed. This allows the user to confirm that this is what they want to do when the selection does not match the text to be replaced.  
  
 Override <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to change the way a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>-derived object replaces text.  
  
##  \<a name="ceditview__onreplacesel">\</a>  CEditView::OnReplaceSel  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> when the user selects the Replace button in the standard Replace dialog box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Specifies whether the search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The text to replace the found text.  
  
### Remarks  
 After replacing the selection, this function searches the text in the buffer for the next occurrence of the text specified by <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, in the direction specified by <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, with case sensitivity specified by <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. The search is accomplished through a call to [FindText](#ceditview__findtext). If the text is not found, [OnTextNotFound](#ceditview__ontextnotfound) is called.  
  
 Override <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to change the way a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>-derived object replaces the selected text.  
  
##  \<a name="ceditview__ontextnotfound">\</a>  CEditView::OnTextNotFound  
 Override this function to change the default implementation, which calls the Windows function **MessageBeep**.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The text to be found.  
  
##  \<a name="ceditview__printinsiderect">\</a>  CEditView::PrintInsideRect  
 Call <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> to print text in the rectangle specified by                 *rectLayout*.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Pointer to the printer device context.  
  
 *rectLayout*  
 Reference to a [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure specifying the rectangle in which the text is to be rendered.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Index within the buffer of the first character to be rendered.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Index within the buffer of the character following the last character to be rendered.  
  
### Return Value  
 The index of the next character to be printed (that is, the character following the last character rendered).  
  
### Remarks  
 If the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> control does not have the style **ES_AUTOHSCROLL**, text is wrapped within the rendering rectangle. If the control does have the style **ES_AUTOHSCROLL**, the text is clipped at the right edge of the rectangle.  
  
 The **rect.bottom** element of the                         *rectLayout* object is changed so that the rectangle's dimensions define the part of the original rectangle that is occupied by the text.  
  
##  \<a name="ceditview__serializeraw">\</a>  CEditView::SerializeRaw  
 Call <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to have a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object read or write the text in the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object to a text file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Reference to the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object that stores the serialized text.  
  
### Remarks  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>'s internal implementation of <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> in that it reads and writes only the text, without preceding object-description data.  
  
##  \<a name="ceditview__setprinterfont">\</a>  CEditView::SetPrinterFont  
 Call <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> to set the printer font to the font specified by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A pointer to an object of type <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>. If **NULL**, the font used for printing is based on the display font.  
  
### Remarks  
 If you want your view to always use a particular font for printing, include a call to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> in your class's <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> function. This virtual function is called before printing occurs, so the font change takes place before the view's contents are printed.  
  
##  \<a name="ceditview__settabstops">\</a>  CEditView::SetTabStops  
 Call this function to set the tab stops used for display and printing.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Width of each tab stop, in dialog units.  
  
### Remarks  
 Only a single tab-stop width is supported. ( <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> objects support multiple tab widths.) Widths are in dialog units, which equal one-fourth of the average character width (based on uppercase and lowercase alphabetic characters only) of the font used at the time of printing or displaying. You should not use <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> must cache the tab-stop value.  
  
 This function modifies only the tabs of the object for which it is called. To change the tab stops for each <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object in your application, call each object's <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> function.  
  
### Example  
 This code fragment sets the tab stops in the control to every fourth character by carefully measuring the font the control uses.  
  
 [!code[NVC_MFCDocView#67](../vs140/codesnippet/CPP/ceditview-class_3.cpp)]  
  
##  \<a name="ceditview__unlockbuffer">\</a>  CEditView::UnlockBuffer  
 Call this member function to unlock the buffer.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 Call <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> after you have finished using the pointer returned by [LockBuffer](#ceditview__lockbuffer).  
  
## See Also  
 [MFC Sample SUPERPAD](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit](../vs140/cedit-class.md)   
 [CDocument](../vs140/cdocument-class.md)   
 [CDocTemplate](../vs140/cdoctemplate-class.md)   
 [CCtrlView](../vs140/cctrlview-class.md)   
 [CRichEditView](../vs140/cricheditview-class.md)