$certPath = "$PWD\wpfPlayground_msix\WpfPlayGround_msix_TemporaryKey.pfx"

# Base64로 인코딩
$pfxBytes = [System.IO.File]::ReadAllBytes($certPath)
$base64 = [System.Convert]::ToBase64String($pfxBytes)

# 파일로 저장
$base64 | Out-File "certificate_base64.txt" -Encoding ASCII -NoNewline

Write-Host "✅ Base64 인코딩 완료!"
Write-Host "파일 위치: certificate_base64.txt"