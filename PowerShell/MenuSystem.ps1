# Simple Menu System for PowerShell

do {
    Write-Host "1. Change to a directory" # -ForegroundColor Green
    Write-Host "2. Delete a file"
    Write-Host "3. Exit the menu."
    Write-Host "Please enter your choice 1-3:"

    $choice = Read-Host

    if ($choice -eq 1) {
        Write-Host "Option 1 selected."
        Write-Host "Please enter the path name to change to:"
        $pathName = Read-Host
        Set-Location $pathName
    }
    elseif ($choice -eq 2) {
        Write-Host "Option 2 selected."
        Write-Host "Please enter the filename to delete:"
        $fileName = Read-Host
        Remove-Item $fileName
    }
    elseif ($choice -eq 3) {
        Write-Host "Exiting the menu system..."
        exit
    }
}
while ($choice -ne 3)
