<template>
  <div>
    <!-- Contact Header -->
    <UPageHero class="relative isolate overflow-hidden bg-primary-700"
      title="Get Started with Federal Contracting"
      description="Ready to navigate the federal contracting landscape? Schedule a consultation to discuss your business goals and learn how we can help you succeed."
      :ui="{
        title: 'text-4xl sm:text-5xl md:text-6xl font-bold text-white',
        description: 'text-sm sm:text-lg text-primary-100 max-w-3xl mx-auto'
      }">
      <NuxtImg src="/conference-table-2.png" alt="Team collaborating around a conference table"
        class="absolute inset-0 -z-10 size-full object-cover brightness-[0.2]" />
      <div class="absolute inset-0 bg-primary-700/40 -z-10"></div>
    </UPageHero>

    <!-- Contact Form Section -->
    <UPageSection class="bg-white" :ui="{
      container: 'max-w-6xl'
    }">
      <div class="grid grid-cols-1 lg:grid-cols-2 gap-12">
        <!-- Contact Form -->
        <div>
          <h2 class="text-2xl sm:text-3xl font-bold text-secondary-900 mb-6">
            Schedule Your Consultation
          </h2>
          <UForm :schema="contactSchema" :state="contactForm" class="space-y-5" @submit="onSubmit">
            <div class="grid grid-cols-1 sm:grid-cols-2 gap-4">
              <UFormField label="First Name" name="firstName" required :ui="{ label: 'text-secondary-700 font-medium' }">
                <template #default="{ error }">
                  <UInput 
                    v-model="contactForm.firstName" 
                    placeholder="John" 
                    size="lg"
                    :color="error ? 'error' : 'neutral'"
                    variant="outline"
                    class="[&_input]:bg-white! w-full"
                  />
                </template>
              </UFormField>
              <UFormField label="Last Name" name="lastName" required :ui="{ label: 'text-secondary-700 font-medium' }">
                <template #default="{ error }">
                  <UInput 
                    v-model="contactForm.lastName" 
                    placeholder="Doe" 
                    size="lg"
                    :color="error ? 'error' : 'neutral'"
                    variant="outline"
                    class="[&_input]:bg-white! w-full"
                  />
                </template>
              </UFormField>
            </div>

            <UFormField label="Email Address" name="email" required :ui="{ label: 'text-secondary-700 font-medium' }">
              <template #default="{ error }">
                <UInput 
                  v-model="contactForm.email" 
                  type="email" 
                  placeholder="john@company.com" 
                  size="lg"
                  :color="error ? 'error' : 'neutral'"
                  variant="outline"
                  class="[&_input]:bg-white! w-full"
                />
              </template>
            </UFormField>

            <UFormField label="Company Name" name="company" required :ui="{ label: 'text-secondary-700 font-medium' }">
              <template #default="{ error }">
                <UInput 
                  v-model="contactForm.company" 
                  placeholder="Your Company LLC" 
                  size="lg"
                  :color="error ? 'error' : 'neutral'"
                  variant="outline"
                  class="[&_input]:bg-white! w-full"
                />
              </template>
            </UFormField>

            <UFormField label="Phone Number" name="phone" :ui="{ label: 'text-secondary-700 font-medium' }">
              <UInput 
                v-model="contactForm.phone" 
                type="tel" 
                placeholder="(555) 123-4567" 
                size="lg"
                color="neutral"
                variant="outline"
                class="[&_input]:bg-white! w-full"
              />
            </UFormField>

            <UFormField label="Primary Interest" name="interest" required :ui="{ label: 'text-secondary-700 font-medium' }">
              <template #default="{ error }">
                <USelect 
                  v-model="contactForm.interest" 
                  :items="interestOptions"
                  size="lg"
                  placeholder="Select your primary interest..."
                  :color="error ? 'error' : 'neutral'"
                  variant="outline"
                  class="[&_button]:bg-white! w-full"
                />
              </template>
            </UFormField>

            <UFormField label="Tell us about your goals and challenges" name="message" :ui="{ label: 'text-secondary-700 font-medium' }">
              <UTextarea 
                v-model="contactForm.message" 
                size="lg"
                :rows="4"
                placeholder="Describe your current situation, goals, and how we can help..."
                color="neutral"
                variant="outline"
                class="[&_textarea]:bg-white! w-full"
              />
            </UFormField>

            <UButton 
              type="submit" 
              size="lg" 
              block 
              color="primary"
              variant="solid"
              icon="i-heroicons-calendar-days"
              :loading="isSubmitting"
              class="bg-primary-700 text-white hover:bg-primary-800 cursor-pointer py-4"
            >
              Schedule Consultation
            </UButton>
          </UForm>
        </div>

        <!-- Contact Information -->
        <div class="lg:pl-8">
          <h2 class="text-2xl sm:text-3xl font-bold text-secondary-900 mb-6">
            What to Expect
          </h2>
          
          <div class="space-y-6">
            <UCard variant="subtle" class="bg-secondary-50">
              <div class="flex items-start gap-4">
                <div class="shrink-0 w-10 h-10 bg-primary-700 rounded-lg flex items-center justify-center">
                  <UIcon name="i-heroicons-clock" class="w-5 h-5 text-white" />
                </div>
                <div>
                  <h3 class="font-semibold text-secondary-900 mb-1">Response Time</h3>
                  <p class="text-secondary-600 text-sm">
                    We respond to all consultation requests within 24 hours during business days.
                  </p>
                </div>
              </div>
            </UCard>

            <UCard variant="subtle" class="bg-secondary-50">
              <div class="flex items-start gap-4">
                <div class="shrink-0 w-10 h-10 bg-primary-700 rounded-lg flex items-center justify-center">
                  <UIcon name="i-heroicons-chat-bubble-left-right" class="w-5 h-5 text-white" />
                </div>
                <div>
                  <h3 class="font-semibold text-secondary-900 mb-1">Consultation Format</h3>
                  <p class="text-secondary-600 text-sm">
                    Initial consultations are conducted via phone or video call and typically last 30-45 minutes.
                  </p>
                </div>
              </div>
            </UCard>

            <UCard variant="subtle" class="bg-secondary-50">
              <div class="flex items-start gap-4">
                <div class="shrink-0 w-10 h-10 bg-primary-700 rounded-lg flex items-center justify-center">
                  <UIcon name="i-heroicons-shield-check" class="w-5 h-5 text-white" />
                </div>
                <div>
                  <h3 class="font-semibold text-secondary-900 mb-1">Confidentiality</h3>
                  <p class="text-secondary-600 text-sm">
                    All information shared during consultations is kept strictly confidential.
                  </p>
                </div>
              </div>
            </UCard>

            <UCard variant="subtle" class="bg-secondary-50">
              <div class="flex items-start gap-4">
                <div class="shrink-0 w-10 h-10 bg-primary-700 rounded-lg flex items-center justify-center">
                  <UIcon name="i-heroicons-document-text" class="w-5 h-5 text-white" />
                </div>
                <div>
                  <h3 class="font-semibold text-secondary-900 mb-1">Preparation</h3>
                  <p class="text-secondary-600 text-sm">
                    Come prepared with questions about your business goals, current challenges, and federal contracting interests.
                  </p>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Newsletter Signup -->
          <UCard variant="outline" class="mt-8 border-primary-200 bg-primary-50">
            <div class="flex items-start gap-4 mb-4">
              <div class="shrink-0 w-10 h-10 bg-primary-700 rounded-lg flex items-center justify-center">
                <UIcon name="i-heroicons-envelope" class="w-5 h-5 text-white" />
              </div>
              <div>
                <h3 class="text-lg font-semibold text-secondary-900">
                  Stay Informed
                </h3>
                <p class="text-secondary-600 text-sm">
                  Get federal contracting insights, tips, and updates delivered to your inbox.
                </p>
              </div>
            </div>
            <UForm :state="newsletterForm" class="flex flex-col sm:flex-row gap-3" @submit="onNewsletterSubmit">
              <UInput 
                v-model="newsletterForm.email" 
                type="email" 
                placeholder="Enter your email" 
                class="flex-1 [&_input]:!bg-white"
                size="lg"
                color="neutral"
                variant="outline"
              />
              <UButton 
                type="submit" 
                color="primary"
                variant="solid"
                size="lg"
                icon="i-heroicons-paper-airplane"
                :loading="isSubscribing"
                class="bg-primary-700 text-white hover:bg-primary-800 cursor-pointer"
              >
                Subscribe
              </UButton>
            </UForm>
          </UCard>
        </div>
      </div>
    </UPageSection>

    <!-- FAQ Section -->
    <UPageSection 
      class="bg-secondary-50" 
      title="Frequently Asked Questions" 
      :ui="{
        title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-secondary-900 text-center'
      }"
    >
      <div class="max-w-2xl w-full mx-auto space-y-4 font-semibold text-secondary-900">
        <UAccordion 
          :items="faqItems" 
          multiple
          :unmount-on-hide="false"
          class="w-full"
          :ui="{
            label: 'font-semibold',
            content: 'font-light text-secondary-700 text-sm'
          }"
        />
      </div>
    </UPageSection>

    <!-- CTA Section -->
    <CTA 
      title="Need More Information?"
      description="Explore our services and resources to learn more about federal contracting opportunities."      
    />
  </div>
</template>

<script setup>
import { z } from 'zod'

// Set page meta for SEO
definePageMeta({
  title: 'Contact - True North Federal Solutions',
  description: 'Schedule a consultation with True North Federal Solutions for expert federal contracting guidance and support.'
})

// Set head for SEO
useHead({
  title: 'Contact Us - True North Federal Solutions',
  meta: [
    {
      name: 'description',
      content: 'Ready to start your federal contracting journey? Contact True North Federal Solutions for expert guidance on contract setup, proposal development, and FAR compliance.'
    },
    {
      name: 'keywords',
      content: 'federal contracting consultation, small business consulting, government contracts, proposal development, FAR compliance'
    }
  ]
})

// Contact form schema
const contactSchema = z.object({
  firstName: z.string().min(1, 'First name is required'),
  lastName: z.string().min(1, 'Last name is required'),
  email: z.string().email('Please enter a valid email address'),
  company: z.string().min(1, 'Company name is required'),
  phone: z.string().optional(),
  interest: z.string().min(1, 'Please select your primary interest'),
  message: z.string().optional()
})

// Contact form state
const contactForm = reactive({
  firstName: '',
  lastName: '',
  email: '',
  company: '',
  phone: '',
  interest: '',
  message: ''
})

// Loading states
const isSubmitting = ref(false)
const isSubscribing = ref(false)

// Interest options for select
const interestOptions = [
  { label: 'Federal Contract Setup', value: 'contract-setup' },
  { label: 'Proposal Development', value: 'proposal-development' },
  { label: 'FAR Compliance', value: 'far-compliance' },
  { label: 'Bid/No-Bid Strategy', value: 'bid-no-bid' },
  { label: 'General Consulting', value: 'general-consulting' },
  { label: 'Certification Assistance', value: 'certification-help' }
]

// FAQ items for accordion
const faqItems = [
  {
    label: 'What should I expect during the initial consultation?',
    content: "During your initial consultation, we'll assess your business readiness for federal contracting, discuss your goals, and identify the best path forward. We'll also answer your specific questions and provide preliminary guidance."
  },
  {
    label: 'Do you work with businesses of all sizes?',
    content: "Yes, we specialize in helping small and mid-size businesses navigate federal contracting. Whether you're just starting or looking to expand your federal presence, we can help."
  },
  {
    label: 'What types of certifications do you help with?',
    content: 'We assist with various certifications including WOSB (Woman-Owned Small Business), VOSB (Veteran-Owned Small Business), 8(a) Business Development, and other specialized certifications.'
  },
  {
    label: 'How long does the federal contracting setup process take?',
    content: 'The timeline varies depending on your specific needs and the complexity of your business. Basic setup can take 4-8 weeks, while comprehensive preparation including certifications may take 3-6 months.'
  }
]

// Newsletter form state
const newsletterForm = reactive({
  email: ''
})

// Form submission handlers
async function onSubmit() {
  isSubmitting.value = true
  try {
    // TODO: Implement form submission logic
    console.log('Contact form submitted:', contactForm)
    await new Promise(resolve => setTimeout(resolve, 1000))
  } finally {
    isSubmitting.value = false
  }
}

async function onNewsletterSubmit() {
  isSubscribing.value = true
  try {
    // TODO: Implement newsletter subscription logic
    console.log('Newsletter subscription:', newsletterForm.email)
    await new Promise(resolve => setTimeout(resolve, 1000))
  } finally {
    isSubscribing.value = false
  }
}
</script>
