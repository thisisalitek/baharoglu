# Fix line endings from LF to CRLF for Windows
Write-Host "Starting line endings fix..."

# Get all relevant files
$files = Get-ChildItem -Recurse -Include *.vb,*.config,*.xml,*.vbproj,*.sln | Where-Object { -not $_.PSIsContainer }

Write-Host "Found $($files.Count) files to process"

$fixedCount = 0

foreach ($file in $files) {
    try {
        # Read the file content
        $content = Get-Content $file.FullName -Raw
        
        if ($content) {
            # First normalize all line endings to LF, then convert to CRLF
            $content = $content -replace "`r`n", "`n"  # Remove any existing CRLF
            $content = $content -replace "`n", "`r`n"  # Convert LF to CRLF
            
            # Write back to file
            [System.IO.File]::WriteAllText($file.FullName, $content)
            
            Write-Host "Fixed: $($file.Name)"
            $fixedCount++
        }
    }
    catch {
        Write-Host "Error processing $($file.FullName): $($_.Exception.Message)" -ForegroundColor Red
    }
}

Write-Host "Completed! Fixed $fixedCount files." -ForegroundColor Green