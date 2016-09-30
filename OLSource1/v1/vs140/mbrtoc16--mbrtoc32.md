---
title: "mbrtoc16, mbrtoc32"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "mbrtoc16"
  - "mbrtoc32"
apilocation: 
  - "api-ms-win-crt-convert-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbrtoc16"
  - "mbrtoc32"
  - "uchar/mbrtoc16"
  - "uchar/mbrtoc32"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "mbrtoc16 function"
  - "mbrtoc32 function"
ms.assetid: 099ade4d-56f7-4e61-8b45-493f1d7a64bd
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbrtoc16, mbrtoc32
Translates the first multibyte character in a narrow string into the equivalent UTF-16 or UTF-32 character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> equivalent of the multibyte character to convert. If null, the function does not store a value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the multibyte character string to convert.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum number of bytes in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to examine for a character to convert. This should be a value between one and the number of bytes, including any null terminator, remaining in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> conversion state object used to interpret the multibyte string to one or more output characters.  
  
## Return Value  
 On success, returns the value of the first of these conditions that applies, given the current <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value:  
  
|Value|Condition|  
|-----------|---------------|  
|0|The next <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or fewer characters converted from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> correspond to the null wide character, which is the value stored if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not null.\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> contains the initial shift state.|  
|Between 1 and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, inclusive|The value returned is the number of bytes of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that complete a valid multibyte character. The converted wide character is stored  if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not null.|  
|-3|The next wide character resulting from a previous call to the function has been stored in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not null. No bytes from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are consumed by this call to the function.\<br />\<br /> When  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> points to a multibyte character that requires more than one wide character to represent (for example, a surrogate pair), then the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value is updated so that the next function call writes  out the additional character.|  
|-2|The next <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bytes represent an incomplete, but potentially valid, multibyte character. No value is stored in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This result can occur if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is zero.|  
|-1|An encoding error has occurred. The next <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or fewer bytes do not contribute to a complete and valid multibyte character. No value is stored in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is stored in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the conversion state <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is unspecified.|  
  
## Remarks  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function reads up to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to find  the first complete, valid multibyte character, and then stores the equivalent UTF-16 character in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The source bytes are interpreted according to the current thread multibyte locale. If the multibyte character requires more than one UTF-16 output character, such as a surrogate pair, then the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> value is set to store the next UTF-16 character in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> on the next call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function is identical, but output is stored as a UTF-32 character.  
  
 If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is null, these functions return the equivalent of a call made using arguments of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>,  and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The passed values of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> are ignored.  
  
 If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is not null, the function starts at the beginning of the string and inspects up to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> bytes to determine the number of bytes required to complete the next multibyte character, including any shift sequences. If the examined bytes contain a valid and complete multibyte character, the function converts the character into the equivalent 16-bit or 32-bit wide character or characters. If <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is not null, the function stores the first (and possibly only) result character in destination. If additional output characters are required, a value is set in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, so that subsequent calls to the function output the additional characters and return the value -3. If no more output characters are required, then <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is set to the initial shift state.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|\<uchar.h>|\<cuchar>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [c16rtomb, c32rtomb](../vs140/c16rtomb--c32rtomb.md)   
 [mbrtowc](../vs140/mbrtowc.md)   
 [mbsrtowcs](../vs140/mbsrtowcs.md)   
 [mbsrtowcs_s](../vs140/mbsrtowcs_s.md)