<template>
  <div>
    <!-- Contact Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <UIcon name="i-heroicons-envelope" class="w-16 h-16 text-primary-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Get Started with Federal Contracting
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Ready to navigate the federal contracting landscape? Schedule a consultation to discuss your business goals
          and learn how we can help you succeed.
        </p>
      </div>
    </section>

    <!-- Contact Form Section -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="grid grid-cols-1 lg:grid-cols-2 gap-12">
          <!-- Contact Form -->
          <div>
            <h2 class="text-2xl font-bold text-gray-900 mb-6">
              Schedule Your Consultation
            </h2>
            <UForm :schema="contactSchema" :state="contactForm" class="space-y-6" @submit="onSubmit">
              <div class="grid grid-cols-1 sm:grid-cols-2 gap-4">
                <UFormField label="First Name" name="firstName" required>
                  <UInput v-model="contactForm.firstName" placeholder="John" size="lg" />
                </UFormField>
                <UFormField label="Last Name" name="lastName" required>
                  <UInput v-model="contactForm.lastName" placeholder="Doe" size="lg" />
                </UFormField>
              </div>

              <UFormField label="Email Address" name="email" required>
                <UInput v-model="contactForm.email" type="email" placeholder="john@company.com" size="lg" />
              </UFormField>

              <UFormField label="Company Name" name="company" required>
                <UInput v-model="contactForm.company" placeholder="Your Company LLC" size="lg" />
              </UFormField>

              <UFormField label="Phone Number" name="phone">
                <UInput v-model="contactForm.phone" type="tel" placeholder="(555) 123-4567" size="lg" />
              </UFormField>

              <UFormField label="Primary Interest" name="interest" required>
                <USelect 
                  v-model="contactForm.interest" 
                  :items="interestOptions"
                  size="lg"
                  placeholder="Select your primary interest..."
                />
              </UFormField>

              <UFormField label="Tell us about your goals and challenges" name="message">
                <UTextarea 
                  v-model="contactForm.message" 
                  size="lg"
                  :rows="4"
                  placeholder="Describe your current situation, goals, and how we can help..."
                />
              </UFormField>

              <UButton type="submit" color="primary" variant="solid" size="lg" block>
                Schedule Consultation
              </UButton>
            </UForm>
          </div>

          <!-- Contact Information -->
          <div>
            <div class="space-y-6">
              <div class="flex items-start space-x-4">
                <UIcon name="i-heroicons-clock" class="w-6 h-6 text-primary-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Response Time</h3>
                  <p class="text-gray-600">
                    We respond to all consultation requests within 24 hours during business days.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <UIcon name="i-heroicons-chat-bubble-left-right" class="w-6 h-6 text-primary-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Consultation Format</h3>
                  <p class="text-gray-600">
                    Initial consultations are conducted via phone or video call and typically last 30-45 minutes.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <UIcon name="i-heroicons-shield-check" class="w-6 h-6 text-primary-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Confidentiality</h3>
                  <p class="text-gray-600">
                    All information shared during consultations is kept strictly confidential.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <UIcon name="i-heroicons-document-text" class="w-6 h-6 text-primary-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Preparation</h3>
                  <p class="text-gray-600">
                    Come prepared with questions about your business goals, current challenges, and federal contracting
                    interests.
                  </p>
                </div>
              </div>
            </div>

            <!-- Newsletter Signup -->
            <div class="mt-12 p-6 bg-blue-50 rounded-lg">
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                Stay Informed
              </h3>
              <p class="text-gray-600 mb-4">
                Get federal contracting insights, tips, and updates delivered to your inbox.
              </p>
              <UForm :state="newsletterForm" class="flex space-x-2" @submit="onNewsletterSubmit">
                <UInput v-model="newsletterForm.email" type="email" placeholder="Enter your email" class="flex-1" />
                <UButton type="submit" color="primary">
                  Subscribe
                </UButton>
              </UForm>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- FAQ Section -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <h2 class="text-3xl font-bold text-gray-900 text-center mb-12">
          Frequently Asked Questions
        </h2>

        <div class="space-y-6">
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              What should I expect during the initial consultation?
            </h3>
            <p class="text-gray-600">
              During your initial consultation, we'll assess your business readiness for federal contracting, discuss
              your goals, and identify the best path forward. We'll also answer your specific questions and provide
              preliminary guidance.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Do you work with businesses of all sizes?
            </h3>
            <p class="text-gray-600">
              Yes, we specialize in helping small and mid-size businesses navigate federal contracting. Whether you're
              just starting or looking to expand your federal presence, we can help.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              What types of certifications do you help with?
            </h3>
            <p class="text-gray-600">
              We assist with various certifications including WOSB (Woman-Owned Small Business), VOSB (Veteran-Owned
              Small Business), 8(a) Business Development, and other specialized certifications.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              How long does the federal contracting setup process take?
            </h3>
            <p class="text-gray-600">
              The timeline varies depending on your specific needs and the complexity of your business. Basic setup can
              take 4-8 weeks, while comprehensive preparation including certifications may take 3-6 months.
            </p>
          </div>
        </div>
      </div>
    </section>
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

// Interest options for select
const interestOptions = [
  { label: 'Federal Contract Setup', value: 'contract-setup' },
  { label: 'Proposal Development', value: 'proposal-development' },
  { label: 'FAR Compliance', value: 'far-compliance' },
  { label: 'Bid/No-Bid Strategy', value: 'bid-no-bid' },
  { label: 'General Consulting', value: 'general-consulting' },
  { label: 'Certification Assistance', value: 'certification-help' }
]

// Newsletter form state
const newsletterForm = reactive({
  email: ''
})

// Form submission handlers
async function onSubmit() {
  // TODO: Implement form submission logic
  console.log('Contact form submitted:', contactForm)
}

async function onNewsletterSubmit() {
  // TODO: Implement newsletter subscription logic
  console.log('Newsletter subscription:', newsletterForm.email)
}
</script>