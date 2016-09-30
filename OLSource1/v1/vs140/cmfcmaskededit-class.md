---
title: "CMFCMaskedEdit Class"
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
  - "CMFCMaskedEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCMaskedEdit class"
  - "CMFCMaskedEdit constructor"
ms.assetid: 13b1a645-2d5d-4c37-8599-16d5003f23a5
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit Class
The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class supports a masked edit control, which validates user input against a mask and displays the validated results according to a template.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCMaskedEdit::DisableMask](#cmfcmaskededit__disablemask)|Disables validating user input.|  
|[CMFCMaskedEdit::EnableGetMaskedCharsOnly](#cmfcmaskededit__enablegetmaskedcharsonly)|Specifies whether the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method retrieves only masked characters.|  
|[CMFCMaskedEdit::EnableMask](#cmfcmaskededit__enablemask)|Initializes the masked edit control.|  
|[CMFCMaskedEdit::EnableSelectByGroup](#cmfcmaskededit__enableselectbygroup)|Specifies whether the masked edit control selects particular groups of user input, or all user input.|  
|[CMFCMaskedEdit::EnableSetMaskedCharsOnly](#cmfcmaskededit__enablesetmaskedcharsonly)|Specifies whether the text is validated against only masked characters, or against the whole mask.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCMaskedEdit::GetWindowText](#cmfcmaskededit__getwindowtext)|Retrieves validated text from the masked edit control.|  
|[CMFCMaskedEdit::SetValidChars](#cmfcmaskededit__setvalidchars)|Specifies a string of valid characters that the user can enter.|  
|[CMFCMaskedEdit::SetWindowText](#cmfcmaskededit__setwindowtext)|Displays a prompt in the masked edit control.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCMaskedEdit::IsMaskedChar](#cmfcmaskededit__ismaskedchar)|Called by the framework to validate the specified character against the corresponding mask character.|  
  
## Remarks  
 Perform the following steps to use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> control in your application:  
  
 1. Embed a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object into your window class.  
  
 2. Call the [EnableMask](#cmfcmaskededit__enablemask) method to specify the mask.  
  
 3. Call the [SetValidChars](#cmfcmaskededit__setvalidchars) method to specify the list of valid characters.  
  
 4. Call the [SetWindowText](#cmfcmaskededit__setwindowtext) method to specify the default text for the masked edit control.  
  
 5. Call the [GetWindowText](#cmfcmaskededit__getwindowtext) method to retrieve the validated text.  
  
 If you do not call one or more methods to initialize the mask, valid characters, and default text, the masked edit control behaves just as the standard edit control behaves.  
  
## Example  
 The following example demonstrates how to set up a mask (for example a phone number) by using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method to create the mask for the masked edit control, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method to specify a string of valid characters that the user can enter, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method to display a prompt in the masked edit control. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#11](../vs140/codesnippet/CPP/cmfcmaskededit-class_1.h)]  
[!code[NVC_MFC_NewControls#12](../vs140/codesnippet/CPP/cmfcmaskededit-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CEdit](../vs140/cedit-class.md)  
  
 [CMFCMaskedEdit](../vs140/cmfcmaskededit-class.md)  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
##  \<a name="cmfcmaskededit__disablemask">\</a>  CMFCMaskedEdit::DisableMask  
 Disables validating user input.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If user input validation is disabled, the masked edit control behaves like the standard edit control.  
  
##  \<a name="cmfcmaskededit__enablegetmaskedcharsonly">\</a>  CMFCMaskedEdit::EnableGetMaskedCharsOnly  
 Specifies whether the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method retrieves only masked characters.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to specify that the [CMFCMaskedEdit::GetWindowText](#cmfcmaskededit__getwindowtext) method retrieve only masked characters; <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to specify that the method retrieve the whole text. The default value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to enable retrieving masked characters. Then create a masked edit control that corresponds to the telephone number, such as (425) 555-0187. If you call the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method, it returns "4255550187". If you disable retrieving masked characters, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method returns the text that is displayed in the edit control, for example "(425) 555-0187".  
  
##  \<a name="cmfcmaskededit__enablemask">\</a>  CMFCMaskedEdit::EnableMask  
 Initializes the masked edit control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A mask string that specifies the type of character that can appear at each position in the user input. The length of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter strings must be the same. See the Remarks section for more detail about mask characters.  
  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A mask template string that specifies the literal characters that can appear at each position in the user input. Use the underscore character ('_') as a character placeholder. The length of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter strings must be the same.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A default character that the framework substitutes for each invalid character in the user input. The default value of this parameter is underscore ('_').  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A string that contains a set of valid characters. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> indicates that all characters are valid. The default value of this parameter is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to create the mask for the masked edit control. Derive a class from the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class and override the [CMFCMaskedEdit::IsMaskedChar](#cmfcmaskededit__ismaskedchar) method to use your own code for custom mask processing.  
  
 The following table list the default mask characters:  
  
|Mask Character|Definition|  
|--------------------|----------------|  
|D|Digit.|  
|d|Digit or space.|  
|+|Plus ('+'), minus ('-'), or space.|  
|C|Alphabetic character.|  
|c|Alphabetic character or space.|  
|A|Alphanumeric character.|  
|a|Alphanumeric character or space.|  
|*|A printable character.|  
  
##  \<a name="cmfcmaskededit__enableselectbygroup">\</a>  CMFCMaskedEdit::EnableSelectByGroup  
 Specifies whether the masked edit control allows the user to select particular groups input, or all input.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to select only groups; <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to select the whole text. The default value is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this function to specify whether the masked edit control allows a user to select by group or the whole text.  
  
 By default, selection by group is enabled. In this case the user can select only continuous groups of valid characters.  
  
 For example, you might use the following masked edit control to validate a telephone number:  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 If selection by group is enabled, the user can retrieve only the "425", "555", or "0187" string groups. If group selection is disabled the user can retrieve the whole text of the telephone number: "(425) 555-0187".  
  
##  \<a name="cmfcmaskededit__enablesetmaskedcharsonly">\</a>  CMFCMaskedEdit::EnableSetMaskedCharsOnly  
 Specifies whether the text is validated against only the masked characters, or against the whole mask.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to validate the user input against only masked characters; <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to validate against the whole mask. The default value is <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcmaskededit__getwindowtext">\</a>  CMFCMaskedEdit::GetWindowText  
 Retrieves validated text from the masked edit control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives the text from the edit control.  
  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The maximum number of characters to receive.  
  
 [out] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A reference to the string object that receives the text from the edit control.  
  
### Return Value  
 The first method overload returns the number of bytes of the string that is copied to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter buffer; 0 if the masked edit control has no text.  
  
### Remarks  
 This method copies the text from the masked edit control to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> buffer or the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> string.  
  
 This method redefines [CWnd::GetWindowText](../vs140/cwnd-class.md#cwnd__getwindowtext).  
  
##  \<a name="cmfcmaskededit__ismaskedchar">\</a>  CMFCMaskedEdit::IsMaskedChar  
 Called by the framework to validate the specified character against the corresponding mask character.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The character to be validated.  
  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The corresponding character from the mask string.  
  
### Return Value  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> parameter is the type of character permitted by the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to validate input characters on your own. For more information about mask characters, see the [CMFCMaskedEdit::EnableMask](#cmfcmaskededit__enablemask) method.  
  
##  \<a name="cmfcmaskededit__setvalidchars">\</a>  CMFCMaskedEdit::SetValidChars  
 Specifies a string of valid characters that the user can enter.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A string that contains the set of valid input characters. <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> means that all characters are valid. The default value of this parameter is <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to define a list of valid characters. If an input character is not in this list, masked edit control will not accept it.  
  
 The following code example accepts only hexadecimal numbers.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
##  \<a name="cmfcmaskededit__setwindowtext">\</a>  CMFCMaskedEdit::SetWindowText  
 Displays a prompt in the masked edit control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Points to a null-terminated string that will be used as a prompt.  
  
### Remarks  
 This method sets the control text.  
  
 This method redefines [CWnd::SetWindowText](../vs140/cwnd-class.md#cwnd__setwindowtext).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CEdit Class](../vs140/cedit-class.md)