<template>
  <div>
    <!-- About Hero -->
    <UPageHero class="relative isolate overflow-hidden bg-primary-700 md:min-h-125" title="About True North Federal Solutions"
      description="At True North Federal Solutions, our mission is to demystify federal contracting
          for small businesses. Led by a former federal Contracting Officer with over 15
          years of experience, we equip you with the tools, strategies, and insights needed
          to become contract-ready, submit competitive proposals, and grow in the public
          sector." :ui="{
            title: 'text-4xl sm:text-5xl md:text-6xl font-bold text-white',
            description: 'text-sm sm:text-lg text-white max-w-3xl mx-auto'
          }">
      <NuxtImg src="/conference-table-2.png" alt="Team collaborating around a conference table"
        class="absolute inset-0 -z-10 size-full object-cover brightness-[0.2]" />
      <div class="absolute inset-0 bg-primary-700/40 -z-10"></div>
    </UPageHero>

    <!-- Meet the Founder -->
    <UPageSection class="bg-secondary-50" title="Meet the Founder" :ui="{
      title: 'text-3xl sm:text-4xl lg:text-5xl text-pretty tracking-tight font-bold text-secondary-900'
    }">
      <UCard variant="naked" class="shadow-sm border-none">
        <div class="text-center mb-6">
          <h3 class="text-2xl font-bold text-secondary-900 mb-2">Jennifer Peterson</h3>
          <p class="text-lg text-primary-600 font-semibold mb-2">
            Founder & Principal Consultant | True North Federal Solutions
          </p>
          <p class="text-md text-secondary-600 italic">
            From the Inside Out: Experience. Integrity. Results.
          </p>
        </div>

        <div class="space-y-6 text-secondary-600">
          <p>
            Jennifer Peterson is a highly accomplished federal acquisition expert with over 15 years
            of experience spanning multiple U.S. government agencies. As the Founder and Principal
            Consultant of True North Federal Solutions, Jennifer brings unmatched insight into the
            federal procurement landscape—earned from years of managing and negotiating
            contracts valued in the hundreds of millions of dollars.
          </p>

          <p>
            Her federal contracting journey began with the Defense Contract Management Agency
            (DCMA) and advanced through roles with the Red River Army Depot, U.S. Army Corps
            of Engineers (USACE), NASA's Johnson Space Center, and the U.S. Department of
            Agriculture (USDA). She has held key leadership roles, including Supervisory Contract
            Specialist and Contracting Officer with an active $75 million warrant, overseeing
            complex acquisition portfolios and mentoring junior specialists.
          </p>

          <p>
            Jennifer has managed full life-cycle acquisition strategies—from pre-award planning and
            cost analysis to post-award administration and contract closeout—across a wide range of
            contract types including FFP, IDIQ, CPAF, and CPIF. During her tenure at NASA, she
            served as Lead Contract Specialist for the $21B NAS15-1000 contract supporting the
            International Space Station, where her negotiation leadership saved the government over
            $16M.
          </p>

          <p>
            Throughout her career, Jennifer has been recognized for her strategic mindset, process
            improvement leadership, and commitment to acquisition excellence. She has conducted
            over 130 peer reviews and closed more than 280 contracts in under six months, ensuring
            compliance, speed, and accuracy for federal missions.
          </p>

          <p>
            Jennifer holds a Bachelor of Science in Business Administration with a concentration in
            Human Resource Management and maintains both the FAC-C Professional Certification
            and DAWIA Level III certification.
          </p>

          <p>
            At True North Federal Solutions, Jennifer's mission is to help small and growing
            businesses navigate the federal contracting world with clarity and confidence. Her
            philosophy is simple: "I've sat at the government table—now I help you win from the
            other side." With deep knowledge of the FAR, contracting strategy, and procurement
            systems, she offers practical, compliance-driven support that empowers clients to
            compete—and succeed—in government markets.
          </p>
        </div>
      </UCard>
    </UPageSection>

    <!-- CTA Section -->
    <CTA
      title="Ready to Start Your Federal Contracting Journey?"
      description="Schedule a consultation to discuss your business goals and learn how we can help you succeed in federal contracting."
      :links="ctaLinks"
    />
  </div>
</template>

<script setup>
const ctaLinks = [
  {
    label: 'Schedule Consultation',
    to: '/contact',
    icon: 'i-heroicons-calendar-days',
    size: 'lg',
    color: 'primary',
    variant: 'solid',
    class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
  },
  {
    label: 'Explore Resources',
    to: '/resources',
    icon: 'i-heroicons-book-open',
    size: 'lg',
    color: 'primary',
    variant: 'solid',
    class: 'flex items-center justify-center px-8 py-3 w-80 bg-secondary-100 hover:bg-secondary-300 hover:text-secondary-900 text-lg'
  }
]

// Set page meta
definePageMeta({
  title: 'About - True North Federal Solutions'
})

// Set head for SEO
useHead({
  title: 'About Us - True North Federal Solutions',
  meta: [
    {
      name: 'description',
      content: 'Learn about True North Federal Solutions and our founder\'s 15+ years of federal contracting experience. Expert guidance for small businesses entering federal contracting.'
    },
    {
      name: 'keywords',
      content: 'federal contracting expert, contracting officer consultant, small business federal contracts, WOSB, VOSB, federal acquisition specialist'
    }
  ]
})
</script>
