import { promises as fs } from 'fs'
import { join } from 'path'

export default defineEventHandler(async () => {
  const guidesDir = join(process.cwd(), 'public', 'guides')
  try {
    const files = await fs.readdir(guidesDir)
    const pdfs = files
      .filter((f) => f.toLowerCase().endsWith('.pdf'))
      .map((f) => ({ name: f, url: '/guides/' + encodeURIComponent(f) }))

    // Sort by name
    pdfs.sort((a, b) => a.name.localeCompare(b.name))

    return { files: pdfs }
  } catch (err) {
    // If the folder doesn't exist or is empty, return empty list instead of throwing
    if ((err as any)?.code === 'ENOENT') {
      return { files: [] }
    }
    throw createError({ statusCode: 500, statusMessage: 'Unable to list guides' })
  }
})
