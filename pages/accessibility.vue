<template>
  <div>
    <NavSection />
    
    <!-- Accessibility Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:globe-alt" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Accessibility Statement
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          True North Federal Solutions is committed to ensuring digital accessibility for all users, including those with disabilities.
        </p>
      </div>
    </section>

    <!-- Accessibility Content -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="prose prose-lg max-w-none">
          
          <h2 class="text-2xl font-bold text-gray-900 mb-6">Our Commitment</h2>
          <p class="text-gray-600 mb-6">
            We are committed to making our website accessible to all users, regardless of technology or ability. We strive to comply with the Web Content Accessibility Guidelines (WCAG) 2.1 Level AA standards.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Accessibility Features</h2>
          <p class="text-gray-600 mb-4">Our website includes the following accessibility features:</p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li><strong>Keyboard Navigation:</strong> All interactive elements can be accessed using keyboard navigation</li>
            <li><strong>Screen Reader Compatibility:</strong> Content is structured for optimal screen reader experience</li>
            <li><strong>Alternative Text:</strong> Images include descriptive alternative text</li>
            <li><strong>Color Contrast:</strong> Text meets WCAG color contrast requirements</li>
            <li><strong>Responsive Design:</strong> Content adapts to different screen sizes and zoom levels</li>
            <li><strong>Semantic HTML:</strong> Proper heading structure and semantic markup</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Supported Technologies</h2>
          <p class="text-gray-600 mb-4">This website is designed to work with:</p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li>Screen readers (NVDA, JAWS, VoiceOver)</li>
            <li>Voice recognition software</li>
            <li>Keyboard-only navigation</li>
            <li>Screen magnification software</li>
            <li>Browser zoom up to 200%</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Ongoing Efforts</h2>
          <p class="text-gray-600 mb-4">We are continuously working to improve accessibility through:</p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li>Regular accessibility audits and testing</li>
            <li>User feedback incorporation</li>
            <li>Staff training on accessibility best practices</li>
            <li>Technology updates to improve compatibility</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Feedback and Contact</h2>
          <p class="text-gray-600 mb-4">
            We welcome your feedback on the accessibility of our website. If you encounter any accessibility barriers or have suggestions for improvement, please contact us:
          </p>
          
          <div class="bg-blue-50 rounded-lg p-6">
            <div class="grid grid-cols-1 md:grid-cols-2 gap-6">
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Email</h4>
                <p class="text-gray-600">accessibility@truenorthfederalsolutions.com</p>
              </div>
              <div>
                <h4 class="font-semibold text-gray-900 mb-2">Response Time</h4>
                <p class="text-gray-600">We aim to respond within 2 business days</p>
              </div>
            </div>
          </div>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Alternative Formats</h2>
          <p class="text-gray-600 mb-6">
            If you need information from this website in an alternative format, please contact us. We can provide materials in large print, audio format, or other accessible formats upon request.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Third-Party Content</h2>
          <p class="text-gray-600 mb-6">
            While we strive to ensure accessibility across our entire website, some third-party content or embedded features may not be fully accessible. We are working with our vendors to improve accessibility of all content.
          </p>

        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Accessibility Statement - True North Federal Solutions',
  description: 'Accessibility statement and commitment to digital inclusion for all users of True North Federal Solutions website.'
})

// Set head for SEO
useHead({
  title: 'Accessibility Statement - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Accessibility statement for True North Federal Solutions. Our commitment to WCAG compliance and digital accessibility for all users.' 
    },
    { 
      name: 'robots', 
      content: 'index, follow' 
    }
  ]
})
</script>