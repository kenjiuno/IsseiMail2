; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 
;
; example2.nsi expands on this by adding a uninstaller and start menu shortcuts.

;--------------------------------

!define APP "IsseiMail2"

!system 'MySign "bin\DEBUG\${APP}.exe"'
!finalize 'MySign "%1"'

; The name of the installer
Name "${APP}"

; The file to write
OutFile "Setup_${APP}.exe"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Build Unicode installer
Unicode True

; The default installation directory
InstallDir "$APPDATA\${APP}"

XPStyle on

;--------------------------------

; Pages

Page directory
Page instfiles

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File /r /x "*.vshost.*" /x "Settei" "bin\DEBUG\*.*"
  
  CreateShortCut "$DESKTOP\一斉メール.lnk" "$INSTDIR\${APP}.exe"
  
SectionEnd
