const fs = require('fs').promises
const path = require('path')

;(async () => {
  try {
    const guidesDir = path.join(process.cwd(), 'public', 'guides')
    // Ensure the directory exists
    await fs.mkdir(guidesDir, { recursive: true })
    const files = await fs.readdir(guidesDir).catch(() => [])
    const pdfs = (files || [])
      .filter((f) => f.toLowerCase().endsWith('.pdf'))
      .map((f) => ({ name: f, url: '/guides/' + encodeURIComponent(f) }))
      .sort((a, b) => a.name.localeCompare(b.name))

    const outPath = path.join(guidesDir, 'index.json')
    await fs.writeFile(outPath, JSON.stringify({ files: pdfs }, null, 2), 'utf8')
    console.log('Generated', outPath)
  } catch (err) {
    console.error('Error generating guides index:', err)
    process.exitCode = 1
  }
})()
