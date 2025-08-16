<template>
  <div>
    <!-- Guides Header (compact, like Resources page) -->
    <BaseSection variant="secondary" spacing="lg" centered>
      <template #header>
        <IconWrapper icon="heroicons:document-arrow-down" variant="success" size="xl" class="mx-auto mb-6" />
        <h1 class="text-4xl text-center font-bold text-secondary-900 mb-4">Guides & Templates</h1>
        <p class="text-xl text-center text-secondary-600 max-w-2xl mx-auto">
          Downloadable guides and templates to help you with federal contracting — available as PDFs for download.
        </p>
      </template>
    </BaseSection>

    <!-- Available Downloads (dynamically lists PDFs from /public/guides) -->
    <BaseSection spacing="lg">
      <div class="max-w-6xl mx-auto">
        <h2 class="text-2xl font-bold text-gray-900 mb-4">Available Downloads</h2>
  <p class="text-gray-600 mb-6">Explore practical guides and editable templates designed to help you plan, prepare, and win federal contracting opportunities.</p>

        <div v-if="loading" class="text-center py-8">Loading available guides...</div>

        <div v-else>
          <div v-if="files.length === 0" class="text-center py-8 text-gray-600">
            No guides available. Place PDFs into <code>/public/guides</code> to make them available for download.
          </div>

          <div v-else class="grid md:grid-cols-2 lg:grid-cols-3 gap-6">
            <BaseCard v-for="file in files" :key="file.url" class="flex flex-col justify-between">
              <div class="p-6">
                <div class="flex items-center mb-3">
                  <span class="bg-emerald-100 text-emerald-800 text-xs font-medium px-2 py-1 rounded">Download</span>
                </div>
                <h4 class="text-lg font-semibold mb-2 truncate">{{ file.name }}</h4>
                <p class="text-gray-600 text-sm mb-4">PDF — Click download to save a copy.</p>
              </div>
              <div class="p-4 border-t">
                <div class="flex items-center justify-between">
                  <span class="text-xs text-gray-500">PDF</span>
                  <a :href="file.url" :download="file.name" class="inline-block">
                    <BaseButton variant="primary" size="sm" icon-right="heroicons:arrow-down-tray">Download</BaseButton>
                  </a>
                </div>
              </div>
            </BaseCard>
          </div>
        </div>
      </div>
    </BaseSection>

    <!-- The rest of the existing guides content isn't strictly necessary here; keep a CTA -->
    <BaseSection>
      <div class="max-w-6xl mx-auto text-center">
        <div class="bg-emerald-50 rounded-lg p-8 mt-12 text-center">
          <h3 class="text-2xl font-bold text-emerald-900 mb-4">Need Custom Guidance?</h3>
          <p class="text-emerald-700 mb-6">Our experts can provide personalized guidance tailored to your specific situation and goals.</p>
          <BaseButton variant="primary" size="lg">
            <NuxtLink to="/contact">Schedule Consultation</NuxtLink>
          </BaseButton>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'

const files = ref([])
const loading = ref(true)

async function loadGuides() {
  loading.value = true
  try {
    const res = await $fetch('/api/guides')
    files.value = res?.files || []
  } catch (e) {
    files.value = []
  } finally {
    loading.value = false
  }
}

onMounted(() => loadGuides())

definePageMeta({
  title: 'Guides & Templates - True North Federal Solutions',
  description: 'Downloadable federal contracting guides and templates.'
})
</script>
